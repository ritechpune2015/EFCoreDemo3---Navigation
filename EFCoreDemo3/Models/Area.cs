using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace EFCoreDemo3.Models
{
    public class Area
    {
        public Int64 AreaID { get; set; }
        public string AreaName { get; set; }
        public virtual List<Dept> Depts { get; set; }
    }
}
