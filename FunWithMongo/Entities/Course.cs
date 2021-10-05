using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.Entities
{
    [Table("course")]
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
