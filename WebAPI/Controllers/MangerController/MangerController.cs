namespace WebAPI.Controllers.MangerController
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using Infrastructure.Repositories;
    using Infrastructure;
    using Domain.SchoolAggregate;
    using Domain.ManagerAggregate;
    using WebAPI.Controllers.Converter;
    using WebAPI.Controllers.Request;
    using WebAPI.Controllers.MangerController.Request;
    using WebAPI.Controllers.MangerController.Converter;

    [ApiController]

    public class MangerController : Controller
    {
        private readonly AppUnitOfWork _unitOfWork;

        public MangerController(AppUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("api/GetMangers")]
        public IActionResult GetMangers()
        {
            IEnumerable<Manger> Mangers;
            using (_unitOfWork)
            {
                Mangers = _unitOfWork.ManagerRep.GetAllMangers();
            }

            return Json(Mangers);
        }


        [HttpPost]
        [Route("api/InsertManger")]
        public IActionResult InsertManger(MangerRequest request)
        {

            Manger manger = new Manger();
            MangerConverter mangerConverter = new MangerConverter();

            _unitOfWork.ManagerRep.InsertManger(manger);
            manger.AddNewManager(mangerConverter.GetMangerInput(request));

            _unitOfWork.SaveChanges();

            return Ok("Data inserted successfully.");
        }

    }
}
