using Demo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Interfaces
{
    public interface ICourseService
    {
       CourseViewModal GetCourses();
        void Create(CourseViewModal courseViewModal);
    }
}
