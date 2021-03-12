using Demo.Application.Interfaces;
using Demo.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICourseService _CourseService;
        public CourseController(ICourseService courseService)
        {
            _CourseService = courseService;
        }
        public IActionResult Index()
        {
            return View(_CourseService.GetCourses());
        }
    }
}
