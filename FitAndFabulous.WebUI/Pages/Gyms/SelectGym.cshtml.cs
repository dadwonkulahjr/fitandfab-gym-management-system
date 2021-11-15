using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitAndFabulous.DataAccess.Services.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitAndFabulous.WebUI.Pages.Gyms
{
    public class SelectGymModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public List<Models.Gym> Gyms { get; set; }
        public SelectGymModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            Gyms = _unitOfWork.Gym.GetMatchingEntityType()
                                      .OrderBy(x => x.Name)
                                      .ToList();
        }
        
    }
}
