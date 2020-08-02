using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Configuration;
using System.Net;
using NLog;

namespace AG.Claims.Common
{
    public static class Log
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"> message to log</param>
        /// <param name="logLevel"></param>
        /// <param name="memberName">name of caller method</param>
        /// <param name="sourceFilePath"> name of caller cs file </param>
        /// <param name="sourceLineNumber"> line number</param>
        public static void CreateLog(string message, Level logLevel, [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0, string callerNameSpace = "")
        {
            LogLevel logLvl = LogLevel.Info;
            switch (logLevel)
            {
                case Level.Trace:
                    logLvl = LogLevel.Trace;
                    break;
                case Level.Debug:
                    logLvl = LogLevel.Debug;
                    break;
                case Level.Info:
                    logLvl = LogLevel.Info;
                    break;
                case Level.Warn:
                    logLvl = LogLevel.Warn;
                    break;
                case Level.Error:
                    logLvl = LogLevel.Error;
                    break;
                case Level.Fatal:
                    logLvl = LogLevel.Fatal;
                    break;
                case Level.Off:
                    logLvl = LogLevel.Off;
                    break;
                default:
                    break;
            }

            var stackFrame = new StackTrace().GetFrame(1);
            if (string.IsNullOrEmpty(callerNameSpace))
                callerNameSpace = stackFrame.GetMethod().ReflectedType.Namespace;

            Logger logger = LogManager.GetLogger(callerNameSpace + "." + stackFrame.GetMethod().ReflectedType.Name);

            string sharedPath = ConfigurationManager.AppSettings["SharedPath"];
            using (new WindowsImpersonator($@"{sharedPath}", new NetworkCredential()
            {
                UserName = ConfigurationManager.AppSettings["SharedPathUserName"],
                Password = ConfigurationManager.AppSettings["SharedPathPassword"]
            }))
            {
                logger.Log(logLvl, "|Message=" + message + " | Method= " + memberName + " |SourceFilePath= " + sourceFilePath + " |Line# = " + sourceLineNumber);
            }
        }

        public static void CreateLog(Exception ex, [CallerMemberName]string memberName = "", [CallerFilePath]string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, string callerNameSpace = "")
        {
            var stackFrame = new StackTrace().GetFrame(1);
            if (string.IsNullOrEmpty(callerNameSpace))
                callerNameSpace = stackFrame.GetMethod().ReflectedType.Namespace;

            Logger logger = LogManager.GetLogger(callerNameSpace + "." + stackFrame.GetMethod().ReflectedType.Name);
            string sharedPath = ConfigurationManager.AppSettings["SharedPath"];
            using (new WindowsImpersonator($@"{sharedPath}", new NetworkCredential()
            {
                UserName = ConfigurationManager.AppSettings["SharedPathUserName"],
                Password = ConfigurationManager.AppSettings["SharedPathPassword"]
            }))
            {
                logger.Error(ex, "|Message= Exeception occured|Method= " + memberName + " |ClassName= " + sourceFilePath + " |Line# = " + sourceLineNumber);
            }
        }

        public static void CreateLogWithTrackID(string message, Level logLevel, string trackID, [CallerMemberName]string memberName = "", [CallerFilePath]string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            var stackFrame = new StackTrace().GetFrame(1);
            var callerNameSpace = stackFrame.GetMethod().ReflectedType.Namespace;

            CreateLog(message + "| TrackId=" + trackID, logLevel, memberName, sourceFilePath, sourceLineNumber, callerNameSpace);
        }

        public static void CreateLogWithTrackID(Exception ex, string trackID, [CallerMemberName]string memberName = "", [CallerFilePath]string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            string callerNameSpace = string.Empty;
            var stackFrame = new StackTrace().GetFrame(1);
            callerNameSpace = stackFrame.GetMethod().ReflectedType.Namespace;

            CreateLog(ex, memberName, sourceFilePath, sourceLineNumber, callerNameSpace);
        }
    }

    public enum Level
    {
        Trace,
        Debug,
        Info,
        Warn,
        Error,
        Fatal,
        Off


    }
}
