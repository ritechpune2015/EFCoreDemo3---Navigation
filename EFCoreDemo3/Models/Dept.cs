using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo3.Models
{
    [Table("TblDept")]
    public class Dept
    {
        [Key]
        public Int64    DID { get; set; }
        public string DeptName { get; set; }
        public Int64 AreaID { get; set; }
        public virtual Area Area { get; set; }
        public virtual List<Emp> Emps { get; set; }
    }
}
