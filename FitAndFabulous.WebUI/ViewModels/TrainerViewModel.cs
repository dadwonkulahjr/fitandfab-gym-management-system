using FitAndFabulous.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FitAndFabulous.WebUI.ViewModels
{
    public class TrainerViewModel
    {
        public TrainerViewModel()
        {
            Person = new();
        }
        public Person Person { get; set; }
        public IEnumerable<SelectListItem> GetDropdownListForGender { get; set; }
        public IEnumerable<SelectListItem> GetDropdownListForSuffix { get; set; }

        public IEnumerable<SelectListItem> GetDropdownListForPosition { get; set; }

    }
}
