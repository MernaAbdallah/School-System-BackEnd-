using Domain.EnrollmentAggregate;

namespace CourseSystem.Controllers
{
    public interface IEnrollmentService
    {
        Enrollment GetEnrollmentById(long id);

        IEnumerable<Enrollment> GetAllEnrollments();

    }
}