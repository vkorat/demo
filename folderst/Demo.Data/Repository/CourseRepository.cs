using Demo.Data.Context;
using Demo.Dmain.Interfaces;
using Demo.Dmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private DemoidentitiyDBContext _ctx;

        public CourseRepository(DemoidentitiyDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.Course.Add(course);
            _ctx.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
        {
            return _ctx.Course;
        }
    }
}
