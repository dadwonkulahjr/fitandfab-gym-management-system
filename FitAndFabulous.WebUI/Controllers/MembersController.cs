using FitAndFabulous.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FitAndFabulous.Utility;

namespace FitAndFabulous.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public MembersController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _applicationDbContext.Members
                                            .Include(x => x.Person)
                                            .Include(x => x.Person.Suffix)
                                            .Include(x => x.Person.Gender)
                                            .Include(x => x.Gym)
                                            .Include(x => x.Person.Position)
                                            .Select(x => new
                                            {
                                                id = x.Id,
                                                fullName = x.Person.LastName + ", " + x.Person.FirstName + " " + x.Person.MiddleName,
                                                gym = x.Gym.Name,
                                                gender = x.Person.Gender.Name,
                                                type = x.Person.Position.Type,
                                                suffix = x.Person.Suffix.Name,
                                                dob = x.Person.Dob.Value.ToShortDateString(),
                                                address = x.Person.Address,
                                                contact = x.Person.Contact,
                                                email = x.Person.Email
                                            })
                                            .Where(x => x.type.StartsWith(SDPosition.MEMBER))
                                            .OrderBy(x => x.fullName)
                                            .ToList();

            return Json(new { data = list });
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var personFound = _applicationDbContext.Persons
                                .Include(x => x.Member)
                                .ThenInclude(x => x.Gym)
                                .FirstOrDefault(x => x.Id == id);



            if (personFound != null)
            {
                _applicationDbContext.Persons.Remove(personFound);
                _applicationDbContext.SaveChanges();
                return Json(new { success = true, message = $"Delete {SDPosition.MEMBER} successfully!" });

            }
            else { return Json(new { success = false, message = $"Error deleting {SDPosition.MEMBER}" }); }

        }
    }
}
