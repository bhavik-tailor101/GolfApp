using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GolfAppTests
{
    [TestClass]
    public class CourseServicesTest
    {
    
        [TestMethod]
        public void AddNewCourse()
        {
            var mockSet = new Mock<DbSet<Course>>();
        }
    }
}
