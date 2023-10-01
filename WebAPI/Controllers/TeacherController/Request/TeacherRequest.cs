using Domain.Lookups;
using Domain.SchoolAggregate;

namespace WebAPI.Controllers.TeacherController.Request
{
    public class TeacherRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        //public TeacherCategory Category { get; set; }

        //public long SchoolId { get; set; }
        //public School School { get; set; }
    }
}
