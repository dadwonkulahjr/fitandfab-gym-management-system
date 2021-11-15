using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FitAndFabulous.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required, StringLength(50), Display(Name ="First name")]
        public string FirstName { get; set; }
        public char? MiddleName { get; set; }
        [Required, StringLength(50), Display(Name ="Last name")]
        public string LastName { get; set; }

        public string Email { get; set; }
        [Required]
        public DateTime? Dob { get; set; }
        [Required]
        public string Address { get; set; }
        public string Image { get; set; }
        [StringLength(50), Required]
        public string Contact { get; set; }
        
        //Foreign Keys

        [Required, Display(Name ="Gender")]
        public int GenderId { get; set; }
        [Required, Display(Name ="Type")]
        public int PositionId { get; set; }
        [Required, Display(Name ="Suffix")]

        public int SuffixId { get; set; }

        [NotMapped, Display(Name ="Fullname")]
        public string FullName
        {
            get
            {
                return string.Concat(LastName + ", " + FirstName + " " + MiddleName);
            }
        }


        //Navigation Properties
        public virtual Gender Gender { get; set; }
        public virtual Position Position { get; set; }

        public virtual Suffix Suffix { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Member Member { get; set; }

        public IList<PersonTrainingClass> PersonTrainingClasses { get; set; }

        public IEnumerable<Membership> Membership{ get; set; }
    }
}
