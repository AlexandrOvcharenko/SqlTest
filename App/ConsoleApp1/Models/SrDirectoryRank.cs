using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class SrDirectoryRank
    {
        public SrDirectoryRank()
        {
            SrQualifDocs = new HashSet<SrQualifDoc>();
        }

        public int Id { get; set; }
        public string NameUkr { get; set; }
        public string NameEng { get; set; }
        public bool IsDisable { get; set; }
        public double? Price { get; set; }
        public int? DirectionId { get; set; }
        public int? TypeDocumentId { get; set; }
        public int? TypeRankId { get; set; }
        public bool IsDkk { get; set; }
        public int? Priority { get; set; }
        public string Uuid { get; set; }

        public virtual ICollection<SrQualifDoc> SrQualifDocs { get; set; }
    }
}
