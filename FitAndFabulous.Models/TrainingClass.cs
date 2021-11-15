using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitAndFabulous.Models
{
    public class TrainingClass
    {
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }

        [Required]
        public TimeSpan Time { get; set; }
        [ForeignKey("Day")]
        public int DayId { get; set; }


        //Navigation Properties
        public virtual Day Day { get; set; }

        public IList<PersonTrainingClass> PersonTrainingClasses { get; set; }




    }
}
