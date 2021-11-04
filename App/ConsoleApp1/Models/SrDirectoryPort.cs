using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class SrDirectoryPort
    {
        public SrDirectoryPort()
        {
            SrQualifDocs = new HashSet<SrQualifDoc>();
        }

        public int Id { get; set; }
        public string CodePort { get; set; }
        public string NameUkr { get; set; }
        public string NameEng { get; set; }
        public string PositionCapitanUkr { get; set; }
        public string PositionCapitanEng { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsDisable { get; set; }

        public virtual ICollection<SrQualifDoc> SrQualifDocs { get; set; }
    }
}
