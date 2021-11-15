using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace FitAndFabulous.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EmployeesController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public ActionResult GetAll()
        {

            var list = _applicationDbContext.Persons
                                        .Include(x => x.Gender)
                                        .Include(x => x.Employee)
                                        .Include(x => x.Position)
                                        .Include(x => x.Suffix)
                                        .Select(x => new
                                        {
                                            id = x.Id,
                                            fullName = x.LastName + ", " + x.FirstName + " " + x.MiddleName,
                                            officeEmail = x.Employee.OfficeEmail,
                                            dob = x.Dob.Value.ToShortDateString(),
                                            address = x.Address,
                                            gender = x.Gender.Name,
                                            type = x.Position.Type,
                                            salary = x.Employee.Salary.Value.ToString("c"),
                                            contact = x.Contact,
                                            dateHire = x.Employee.DateHire.Value.ToShortDateString(),
                                            suffix = x.Suffix.Name
                                        })
                                        .Where(x => x.type.StartsWith(SDPosition.EMPLOYEE))
                                        .ToList();
            return Json(new { data = list });

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var personFound = _applicationDbContext.Persons.FirstOrDefault(x => x.Id == id);


            if (personFound != null)
            {
                _applicationDbContext.Persons.Remove(personFound);
                _applicationDbContext.SaveChanges();
                return Json(new { success = true, message = $"Delete {SDPosition.EMPLOYEE} successfully!" });

            }
            else { return Json(new { success = false, message = $"Error deleting {SDPosition.EMPLOYEE}" }); }

        }



    }
}
