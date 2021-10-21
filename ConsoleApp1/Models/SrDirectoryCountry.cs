using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class SrDirectoryCountry
    {
        public SrDirectoryCountry()
        {
            SrQualifDocs = new HashSet<SrQualifDoc>();
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public string ValueEng { get; set; }
        public string ValueAbbr { get; set; }

        public virtual ICollection<SrQualifDoc> SrQualifDocs { get; set; }
    }
}
