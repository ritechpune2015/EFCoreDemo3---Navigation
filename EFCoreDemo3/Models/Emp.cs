using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo3.Models
{
    [Table("TblEmp")]
    public class Emp
    {
        [Key]
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public decimal Salary { get; set; }
        // convention - create same name and type property in foreign key class as that of key property in related class 
         [ForeignKey("DeptObj")]
         public Int64 DeptID { get; set; }

        public virtual Dept   DeptObj { set; get; }
    }

}
