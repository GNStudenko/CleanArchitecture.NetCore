using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infraestructure.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace CleanArchitecture.Infraestructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }
    }
}
