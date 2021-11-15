using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitAndFabulous.Models
{
    public class Package
    {
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }

        [Column(TypeName = "money"), Required]
        public decimal Amount { get; set; }

        [StringLength(255)]
        public string Description { get; set; }


        public IEnumerable<Membership> Memberships { get; set; }
    }
}
