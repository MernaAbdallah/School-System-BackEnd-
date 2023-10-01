using Domain.TeacherAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface ITeacherRepository
    {
        void InsertTeacher(Teacher teacher);
        public IEnumerable<Teacher> GetAllTeachers();
    }
}
