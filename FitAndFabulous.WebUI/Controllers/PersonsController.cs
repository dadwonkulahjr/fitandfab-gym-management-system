using FitAndFabulous.DataAccess.Services.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FitAndFabulous.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PersonsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _unitOfWork.Person.GetMatchingEntityType(navigationProperty: "Gender,Position,Suffix")
                              .Select(x => new
                              {
                                  id = x.Id,
                                  fullName = x.LastName + ", " + x.FirstName + " " + x.MiddleName,
                                  email = x.Email,
                                  dob = x.Dob.Value.ToLongDateString(),
                                  address = x.Address,
                                  gender = x.Gender.Name,
                                  type = x.Position.Type,
                                  suffix = x.Suffix.Name

                              })
                              .OrderBy(x => x.fullName)
                              .ToList();

            return Json(new { data = list });
        }
    }
}
