using Microsoft.AspNetCore.Mvc;

namespace CourseSystem.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }

       
    }
}
