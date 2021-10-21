using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class SrQualifDoc
    {
        public SrQualifDoc()
        {
            SrQdServiceInfos = new HashSet<SrQdServiceInfo>();
        }

        public int Id { get; set; }
        public int DnNumber { get; set; }
        public int DnYaer { get; set; }
        public int DnPort { get; set; }
        public DateTime DtIssue { get; set; }
        public int DType { get; set; }
        public int DStatus { get; set; }
        public int Rank { get; set; }
        public string SfSurname { get; set; }
        public string SfName { get; set; }
        public string SfPatronymic { get; set; }
        public string SfFn { get; set; }
        public string SfLn { get; set; }
        public DateTime SfDob { get; set; }
        public int? SfCs { get; set; }
        public int? PortCapitan { get; set; }
        public string SbLeter { get; set; }
        public int? SbNumber { get; set; }

        public virtual SrDirectoryStatusdocument DStatusNavigation { get; set; }
        public virtual SrDirectoryTypedocument DTypeNavigation { get; set; }
        public virtual SrDirectoryPort DnPortNavigation { get; set; }
        public virtual SrDirectoryRank RankNavigation { get; set; }
        public virtual SrDirectoryCountry SfCsNavigation { get; set; }
        public virtual ICollection<SrQdServiceInfo> SrQdServiceInfos { get; set; }
    }
}
