using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitAndFabulous.Models
{
    public class Gym
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
      
    }
}
