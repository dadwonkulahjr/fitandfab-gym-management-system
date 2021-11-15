using FitAndFabulous.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAndFabulous.WebUI.ViewModels
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            Person = new();
            Person.Employee = new();
        }
        public Person Person { get; set; }
        public IEnumerable<SelectListItem> GetDropdownListForGender { get; set; }
        public IEnumerable<SelectListItem> GetDropdownListForSuffix { get; set; }

        public IEnumerable<SelectListItem> GetDropdownListForPosition { get; set; }
    }
}
