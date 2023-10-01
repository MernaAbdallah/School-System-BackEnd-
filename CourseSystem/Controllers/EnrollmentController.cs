using Microsoft.AspNetCore.Mvc;


namespace CourseSystem.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        public IActionResult Index()
        {
            var enrollments = _enrollmentService.GetAllEnrollments();
            return View(enrollments);
        }

        public IActionResult Details(int id)
        {
            var enrollment = _enrollmentService.GetEnrollmentById(id);

            if (enrollment == null)
            {
                return NotFound();
            }

            return View(enrollment);
        }

        
    }
}
