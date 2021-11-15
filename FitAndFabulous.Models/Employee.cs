using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitAndFabulous.Models
{
    public class Employee
    {
        [Key, ForeignKey("Person")]
        public int Id { get; set; }
        [Column(TypeName = "date"), Display(Name ="Date Hire"), Required]
        public DateTime? DateHire { get; set; }
        [Column(TypeName = "money"), Display(Name ="Wage"), Required]
        public decimal? Salary { get; set; }
        [Required, StringLength(50), Display(Name ="Office Email")]
        public string OfficeEmail { get; set; }

        //Navigation Property
        public virtual Person Person { get; set; }

    }
}
