using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitAndFabulous.Models
{
    public class AccessDays
    {
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan Time { get; set; }

        public IEnumerable<Membership> Memberships { get; set; }
    }
}
