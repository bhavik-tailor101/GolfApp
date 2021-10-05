using GolfApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.Services
{
    public class CourseServices
    {
        private GolfDBContext _context;

        public CourseServices(GolfDBContext context)
        {
            _context = context;
        }
        
        public Course GetCourse()
        {
            return _context.Courses.Single();
        }
    }
}
