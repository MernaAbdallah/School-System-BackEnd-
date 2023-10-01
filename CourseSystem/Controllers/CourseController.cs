using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Cors.Infrastructure;

namespace CourseSystem.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var courses = _courseService.GetAllCourses();
            return View(courses);
        }

        public IActionResult Details(long id)
        {
            var course = _courseService.GetCourseById(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // Add other actions for managing courses, such as creating, updating, and deleting
    }
}
