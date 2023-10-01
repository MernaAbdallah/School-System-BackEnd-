using Domain.CourseAggregate;

namespace CourseSystem.Controllers
{
    public interface ICourseService
    {
        object GetAllCourses();
        Course GetCourseById(long id);

        
    }
}