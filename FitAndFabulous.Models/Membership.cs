using FitAndFabulous.Utility;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitAndFabulous.Models
{
    public class Membership
    {
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        public Status? Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime ExpiryDate { get; set; }
        [StringLength(255)]

        public string Description { get; set; }


        //Foreign Keys
        [ForeignKey("Person"), Display(Name = "Person")]
        public int PersonId { get; set; }
        [ForeignKey("Package"), Display(Name = "Package")]
        public int PackageId { get; set; }
        [ForeignKey("AccessDays"), Display(Name="Access Days")]
        public int AccessDaysId { get; set; }



        //Navigation Properties
        public virtual Package Package { get; set; }
        public virtual AccessDays AccessDays { get; set; }
        public virtual Person Person { get; set; }

    }
}
