using System;
using System.Runtime.Serialization;
using AG.Claims.Integration.Types;

namespace AG.Claims.ClueDataExchange
{
    [DataContract(Namespace = "")]
    public class ClueHeader
    {
        //Clue Header Fields
        [DataMember(Order = 1)]
        [MaxLength(PadLength = 4)]
        public string Constant { get; set; }
        [DataMember(Order = 2)]
        [MaxLength(PadLength = 4)]
        public string RecordIndentifier { get; set; }
        [DataMember(Order = 3)]
        [MaxLength(PadLength = 5)]
        public string TransmissionDate { get { return string.Format("{0}{1}", DateTime.Now.ToString("yy"), DateTime.Now.DayOfYear.ToString().PadLeft(3, '0')); } }
        [DataMember(Order = 4)]
        [MaxLength(PadLength = 4)]
        public string TransmissionTime { get { return string.Format(DateTime.Now.TimeOfDay.ToString("hhmm")); } }
        [DataMember(Order = 5)]
        [MaxLength(PadLength = 4)]
        public string ApplicationId { get; set; }
        [DataMember(Order = 6)]
        [MaxLength(PadLength = 10)]
        public string SecondaryPassword { get; set; }
        [DataMember(Order = 7)]
        [MaxLength(PadLength = 9)]
        public string SourceId { get; set; }
        [DataMember(Order = 8)]
        [MaxLength(PadLength = 9)]
        public string DestinationId { get; set; }
        [DataMember(Order = 9)]
        [MaxLength(PadLength = 20)]
        public string CustomerName { get; set; }
        [DataMember(Order = 10)]
        [MaxLength(PadLength = 1)]
        public string RecordFormat { get; set; }
        [DataMember(Order = 11)]
        [MaxLength(PadLength = 1)]
        public string PrintImageControl { get; set; }
        [DataMember(Order = 12)]
        [MaxLength(PadLength = 5)]
        public string MaxRecordLength { get; set; }
        [DataMember(Order = 13)]
        [MaxLength(PadLength = 1)]
        public string RestartReqLevel { get; set; }
        [DataMember(Order = 14)]
        [MaxLength(PadLength = 8)]
        public string RestartBlockNumber { get; set; }
        [DataMember(Order = 15)]
        [MaxLength(PadLength = 1)]
        public string TransactionFormat { get; set; }
        [DataMember(Order = 16)]
        [MaxLength(PadLength = 10)]
        public string FileSize { get; set; }
        [DataMember(Order = 17)]
        [MaxLength(PadLength = 1)]
        public string FileSizeUnits { get; set; }
        [DataMember(Order = 18)]
        [MaxLength(PadLength = 8)]
        public string AlternateDate { get { return DateTime.Now.ToString("yyyyMMdd"); } }
        [DataMember(Order = 19)]
        [MaxLength(PadLength = 1)]
        public string Filler1 { get; set; }
        [DataMember(Order = 20)]
        [MaxLength(PadLength = 30)]
        public string DestinationFileName { get; set; }
        [DataMember(Order = 21)]
        [MaxLength(PadLength = 8)]
        public string ReportingBeginDate { get; set; }
        [DataMember(Order = 22)]
        [MaxLength(PadLength = 8)]
        public string ReportingEndDate { get { return string.Format("{0}{1}", (DateTime.Now.Year / 100) , DateTime.Now.ToString("yyMMdd")); } }
        [DataMember(Order = 23)]
        [MaxLength(PadLength = 24)]
        public string Filler2 { get; set; }
        [DataMember(Order = 24)]
        [MaxLength(PadLength = 80)]
        public string DestinationPathName { get; set; }

    }

    [DataContract(Namespace = "")]
    public class ClueTrailer
    {
        //Clue Trailer Fields 
        [DataMember(Order = 1)]
        [MaxLength(PadLength = 4)]
        public string Constant { get; set; }
        [DataMember(Order = 2)]
        [MaxLength(PadLength = 4)]
        public string RecordIndentifier { get; set; }
        [DataMember(Order = 3)]
        [MaxLength(PadLength = 5)]
        public string TransmissionDate { get { return string.Format("{0}{1}", DateTime.Now.ToString("yy"), DateTime.Now.DayOfYear.ToString().PadLeft(3, '0')); } }
        [DataMember(Order = 4)]
        [MaxLength(PadLength = 4)]
        public string TransmissionTime { get { return string.Format(DateTime.Now.TimeOfDay.ToString("hhmm")); } }
        [DataMember(Order = 5)]
        [MaxLength(PadLength = 4)]
        public string ApplicationId { get; set; }
        [DataMember(Order = 6)]
        [MaxLength(PadLength = 10)]
        public string Filler1 { get; set; }
        [DataMember(Order = 7)]
        [MaxLength(PadLength = 9)]
        public string SourceId { get; set; }
        [DataMember(Order = 8)]
        [MaxLength(PadLength = 6)]
        public string TotalRecords { get; set; }
        [DataMember(Order = 9)]
        [MaxLength(PadLength = 8)]
        public string TotalBlocks { get; set; }
        [DataMember(Order = 10)]
        [MaxLength(PadLength = 10)]
        public string TotalBytes { get; set; }
        [DataMember(Order = 11)]
        [MaxLength(PadLength = 8)]
        public string AlternateDate { get { return DateTime.Now.ToString("yyyyMMdd"); } }
        [DataMember(Order = 12)]
        [MaxLength(PadLength = 34)]
        public string Filler2 { get; set; }
        [DataMember(Order = 13)]
        [MaxLength(PadLength = 150)]
        public string ApplicationArea { get; set; }
    }
}
