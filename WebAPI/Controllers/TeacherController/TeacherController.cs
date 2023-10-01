using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Infrastructure.Repositories;
using Infrastructure;
using Domain.SchoolAggregate;
using WebAPI.Controllers.Request;
using WebAPI.Controllers.Converter;
using Domain.TeacherAggregate;
using WebAPI.Controllers.TeacherController.Request;
using WebAPI.Controllers.TeacherController.TeacherConverter;

namespace WebAPI.Controllers.SchoolController;

[ApiController]

public class TeacherController : Controller
{
    private readonly AppUnitOfWork _unitOfWork;

    public TeacherController(AppUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    [HttpGet]
    [Route("api/GetTeachers")]
    public IActionResult GetTeachers()
    {
        IEnumerable<Teacher> teachers;
        using (_unitOfWork)
        {
            teachers = _unitOfWork.TeacherRep.GetAllTeachers();
        }
        return Json(teachers);
    }

    [HttpPost]
    [Route("api/InsertTeacher")]
    public IActionResult InsertTeacher(TeacherRequest request)
    {

        Teacher teacher = new Teacher();
        TeacherConverter teacherConverter = new TeacherConverter();

        _unitOfWork.TeacherRep.InsertTeacher(teacher);
        teacher.AddNewTeacher(teacherConverter.GetTeacherInput(request));

        _unitOfWork.SaveChanges();

        return Ok("Data inserted successfully.");
    }



}
