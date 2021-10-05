using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.DTOs
{
    public class GolfScore
    {
        public Dictionary<string, Dictionary<int, string>> Scores { get; set; }
    }
}
