using Domain.SchoolAggregate.Input;
using Domain.TeacherAggregate.Input;
using WebAPI.Controllers.TeacherController.Request;

namespace WebAPI.Controllers.TeacherController.TeacherConverter
{
    public class TeacherConverter
    {
        public TeacherInput GetTeacherInput(TeacherRequest request)
        {


            TeacherInput teacherInput = new TeacherInput();
            teacherInput.Name = request.Name;
            teacherInput.Email = request.Email;
            //teacherInput.School = request.School;
            //teacherInput.SchoolId = request.SchoolId;
            //teacherInput.Category = request.Category;


            return teacherInput;

        }
    }
}
