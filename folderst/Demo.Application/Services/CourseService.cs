using AutoMapper;
using AutoMapper.QueryableExtensions;
using Demo.Application.Interfaces;
using Demo.Application.ViewModels;
using Demo.Dmain.Commands;
using Demo.Dmain.Interfaces;
using Demo.Domain.Core.Bus;
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
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus , IMapper autoMapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CourseViewModal courseViewModal)
        {
            //var createCourseCommand = new CreateCourseCommand(
            //    courseViewModal.Name,
            //    courseViewModal.Description,
            //    courseViewModal.ImageUrl
            //    );

            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseViewModal));
        }

        public IEnumerable<CourseViewModal> GetCourses()
        {
            //return new CourseViewModal()
            //{
            //    Courses = _courseRepository.GetCourses()
            //};
            return _courseRepository.GetCourses().ProjectTo<CourseViewModal>(_autoMapper.ConfigurationProvider);
        }
    }
}
