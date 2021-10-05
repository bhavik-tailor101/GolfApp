using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfApp.Entities;
using GolfApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GolfApp.Controllers
{
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private CourseServices _courseService;
        public CourseController(CourseServices courseServices)
        {
            _courseService = courseServices;
        }

        // GET: api/<controller>
        [HttpGet]
        public Course Get()
        {
            return _courseService.GetCourse();
        }
    }
}
