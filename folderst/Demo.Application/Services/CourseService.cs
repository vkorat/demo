using Demo.Application.Interfaces;
using Demo.Application.ViewModels;
using Demo.Dmain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository; 
        }
        public CourseViewModal GetCourses()
        {
            return new CourseViewModal()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
