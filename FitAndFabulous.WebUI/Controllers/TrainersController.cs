using FitAndFabulous.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FitAndFabulous.Utility;

namespace FitAndFabulous.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainersController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public TrainersController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _applicationDbContext.Persons
                                        .Include(x => x.Gender)
                                        .Include(x => x.Position)
                                        .Include(x => x.Suffix)
                                        .Select(x => new
                                        {
                                            id = x.Id,
                                            fullName = x.LastName + ", " + x.FirstName + " " + x.MiddleName,
                                            type = x.Position.Type,
                                            gender = x.Gender.Name,
                                            dob = x.Dob.Value.ToShortDateString(),
                                            email = x.Email,
                                            address = x.Address,
                                            contact = x.Contact,
                                            suffix = x.Suffix.Name
                                        })
                                        .Where(x => x.type.StartsWith(SDPosition.TRAINER))
                                        .OrderBy(x => x.fullName)
                                        .ToList();


            return Json(new { data = list });
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var trainerFound = _applicationDbContext.Persons
                                        .FirstOrDefault(x => x.Id == id);



            if (trainerFound != null)
            {
                _applicationDbContext.Persons.Remove(trainerFound);
                _applicationDbContext.SaveChanges();
                return Json(new { success = true, message = $"Delete {SDPosition.TRAINER} successfully!" });

            }
            else { return Json(new { success = false, message = $"Error deleting {SDPosition.TRAINER}" }); }

        }
    }
}

