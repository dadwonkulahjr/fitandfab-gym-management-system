using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FitAndFabulous.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonTrainingClassesController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public PersonTrainingClassesController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _applicationDbContext.PersonTrainingClasses.ToList();
                                       


            return Json(new { data = list });
                                        
        }
    }
}
