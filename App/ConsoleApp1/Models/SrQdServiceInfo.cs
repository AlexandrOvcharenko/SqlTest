using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class SrQdServiceInfo
    {
        public int Id { get; set; }
        public int QdId { get; set; }
        public string Link { get; set; }
        public int? MrId { get; set; }
        public int? PrId { get; set; }

        public virtual SrQualifDoc Qd { get; set; }
    }
}
