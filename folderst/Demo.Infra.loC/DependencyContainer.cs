using Demo.Application.Interfaces;
using Demo.Application.Services;
using Demo.Data.Repository;
using Demo.Dmain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infra.loC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICourseService,CourseService>();

            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
