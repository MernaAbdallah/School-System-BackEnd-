using Domain.SchoolAggregate.Input;
using WebAPI.Controllers.Request;

namespace WebAPI.Controllers.Converter;

public class StudentConverter
{
    internal SchoolInput GetSchooleInput(StudentCourseTeacherDataRequest request)
    {
        SchoolInput school = new SchoolInput();
        //school.Name = request.Name;
        //foreach (var stu in request.studentRequestsList)
        //{
        //    school.studentInputs.Add(new StudentInput()
        //    {
        //        Email = stu.Email,
        //        Name = stu.Name
        //    });
        //}


        return school;
    }
}
