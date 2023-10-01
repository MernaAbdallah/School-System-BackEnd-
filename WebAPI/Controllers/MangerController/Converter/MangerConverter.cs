using Domain.ManagerAggregate.Input;
using Domain.SchoolAggregate.Input;
using WebAPI.Controllers.MangerController.Request;
using WebAPI.Controllers.Request;

namespace WebAPI.Controllers.MangerController.Converter
{
    public class MangerConverter
    {
        internal MangerInput GetMangerInput(MangerRequest request)
        {
            MangerInput input = new MangerInput();
            input.Name = request.Name;
            input.Email = request.Email;

            return input;
        }
    }
}
