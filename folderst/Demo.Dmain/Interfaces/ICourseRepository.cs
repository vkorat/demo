using Demo.Dmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Dmain.Interfaces
{
    public interface ICourseRepository 
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}
