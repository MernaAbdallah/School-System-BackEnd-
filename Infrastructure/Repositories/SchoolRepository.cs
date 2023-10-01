using Infrastructure.Context;
using Domain.SchoolAggregate; 
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Domain.TeacherAggregate;

namespace Infrastructure.Repositories
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly AppDbContext _context;

        public SchoolRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList(); 
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.ToList(); 
        }

        public IEnumerable<School> GetAllSchools()
        {
            return _context.Schools.ToList(); 
        }

        public void InsertSchool(School school)
        {
            _context.Schools.Add(school);

        }

        public void InsertStudent(Student student)
        {
            _context.Students.Add(student);

        }

        public void InsertCourse(Course course)
        {
            _context.Courses.Add(course);

        }



    }
}
