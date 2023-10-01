using Domain.ManagerAggregate;
using Domain.SchoolAggregate;
using Domain.TeacherAggregate;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly AppDbContext _context;

        public TeacherRepository(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }

        public void InsertTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);

        }

    }


}
