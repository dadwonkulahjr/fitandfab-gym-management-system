using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FitAndFabulous.Models
{
    public class Member
    {
        [ForeignKey("Person")]
        public int Id { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Display(Name ="Gym")]
        public int GymId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Gym Gym { get; set; }
    }
}
