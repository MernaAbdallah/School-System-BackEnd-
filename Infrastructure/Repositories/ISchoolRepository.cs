using Domain.SchoolAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface ISchoolRepository
    {
  
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Course> GetAllCourses();
        IEnumerable<School> GetAllSchools();
        void InsertSchool(School school);
        void InsertStudent(Student student);
        void InsertCourse(Course course);
    }
}
