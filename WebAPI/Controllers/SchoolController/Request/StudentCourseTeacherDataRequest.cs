using Domain.SchoolAggregate;
using Domain.TeacherAggregate;

namespace WebAPI.Controllers.Request;

public class StudentCourseTeacherDataRequest
{
    public string SchoolName { get; set; }
    //  public List<StudentRequest> studentRequestsList { get; set; } = new List<StudentRequest>();
}
public class StudentRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
}