
using CleanArch.Infra.Bus;
using Demo.Application.Interfaces;
using Demo.Application.Services;
using Demo.Data.Repository;
using Demo.Dmain.Interfaces;
using Demo.Domain.Core.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Demo.Dmain.Commands;
using Demo.Dmain.CommandHandlers;
using Demo.Data.Context;

namespace Demo.Infra.loC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            services.AddScoped<ICourseService, CourseService>();

            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddScoped<DemoidentitiyDBContext>();
        }
    }
}
