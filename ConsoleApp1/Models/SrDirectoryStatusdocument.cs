using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class SrDirectoryStatusdocument
    {
        public SrDirectoryStatusdocument()
        {
            SrQualifDocs = new HashSet<SrQualifDoc>();
        }

        public int Id { get; set; }
        public string NameUkr { get; set; }
        public string NameEng { get; set; }
        public bool IsDisable { get; set; }
        public string ForService { get; set; }
        public bool CanUserChange { get; set; }

        public virtual ICollection<SrQualifDoc> SrQualifDocs { get; set; }
    }
}
