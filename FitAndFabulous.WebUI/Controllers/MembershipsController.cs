using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FitAndFabulous.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipsController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public MembershipsController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _applicationDbContext.Memberships
                                        .Include(x => x.Person)
                                        .Include(x => x.Person.Gender)
                                        .Include(x => x.Person.Suffix)
                                        .Include(x => x.AccessDays)
                                        .Include(x => x.Package)
                                        .Select(x => new
                                        {
                                            id = x.Id,
                                            fullName = x.Person.LastName + ", " + x.Person.FirstName + " " + x.Person.MiddleName,
                                            gender = x.Person.Gender.Name,
                                            suffix = x.Person.Suffix.Name,
                                            dob = x.Person.Dob.Value.ToShortDateString(),
                                            package = x.Package.Name,
                                            accessDays = x.AccessDays.Date.ToShortDateString(),
                                            accessTime = x.AccessDays.Time.ToString(),
                                            dateCreated = x.DateCreated.ToShortDateString(),
                                            dateExpiry = x.ExpiryDate.ToShortDateString(),
                                            packageAmount = x.Package.Amount.ToString("c"),
                                            membershipName = x.Name,
                                            status = Enum.GetNames(typeof(Status)).FirstOrDefault()
                                        })
                                        .OrderBy(x => x.fullName)
                                        .ToList();

            return Json(new { data = list });
        }

    }
}
