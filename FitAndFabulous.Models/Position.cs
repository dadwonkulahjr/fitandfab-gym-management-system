using System.ComponentModel.DataAnnotations;

namespace FitAndFabulous.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Type { get; set; }
    }
}
