using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Infrastructure.Repositories;
using Infrastructure;
using Domain.SchoolAggregate;
using WebAPI.Controllers.Request;
using WebAPI.Controllers.Converter;

namespace WebAPI.Controllers.SchoolController;

[ApiController]

public class StudentController : Controller
{
    /*private readonly IStudentRepository _studentRepository; 

    public StudentController(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    */

    private readonly AppUnitOfWork _unitOfWork;

    public StudentController(AppUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    /* private readonly ISchoolRepository _schoolRepository; 
     public StudentController(ISchoolRepository schoolRepository)
     {
         _schoolRepository = schoolRepository;
     }*/


    /*[HttpGet]
    [Route("api/GetStudents")]
    public IActionResult GetStudents()
    {

        IEnumerable<Student> students = _studentRepository.GetAllStudents();
        return Json(students);

        //return View(students);
    }*/

    /*[HttpGet]
    [Route("api/GetStudents")]
    public IActionResult Index()
    {
        IEnumerable<Student> students;

        using (_unitOfWork)
        {
            students = _unitOfWork.StudentRep.GetAllStudents();
        }

        return Json(students);
    }*/

    [HttpGet]
    [Route("api/GetStudents")]
    public IActionResult GetStudents()
    {
        IEnumerable<Student> students;
        using (_unitOfWork)
        {
            students = _unitOfWork.SchoolRep.GetAllStudents();
        }
        // = _schoolRepository.GetAllStudents();
        return Json(students);
    }

    [HttpPost]
    [Route("api/InsertStudentCourseTeacher")]
    public IActionResult InsertStudentCourseTeacher(StudentCourseTeacherDataRequest request)
    {

        School school = new School();
        StudentConverter studentConverter = new StudentConverter();

        _unitOfWork.SchoolRep.InsertSchool(school);
        school.AddNewSchole(studentConverter.GetSchooleInput(request));

        _unitOfWork.SaveChanges();

        return Ok("Data inserted successfully.");
    }




}
