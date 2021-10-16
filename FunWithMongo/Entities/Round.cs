using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.Entities
{
    public class Round
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        [ForeignKey("course_id")]
        public Course course { get; set; }
    }
}
