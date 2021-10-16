using GolfApp.DTOs;
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

        public void AddCourse(CourseDTO course)
        {

            Course newCourse = new Course
            {
                name = course.CourseName
            };

            _context.Add(newCourse);
            _context.SaveChanges(); //need to change name to text not char[]
        }
    }
}
