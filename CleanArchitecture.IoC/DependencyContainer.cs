using CleanArchitecture.Infraestructure.Data.Interfaces;
using CleanArchitecture.Infraestructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // CleanArchitecture.Data
            services.AddScoped<ICourseRepository, CourseRepository>();
        }

    }
}
