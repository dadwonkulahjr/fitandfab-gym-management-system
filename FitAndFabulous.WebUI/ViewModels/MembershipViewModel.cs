using FitAndFabulous.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAndFabulous.WebUI.ViewModels
{
    public class MembershipViewModel
    {
        public MembershipViewModel()
        {
            Membership = new();
        }
        public Membership Membership { get; set; }
        public IEnumerable<SelectListItem> GetDropdownListForGender { get; set; }

        public IEnumerable<SelectListItem> GetDropdownListForPerson { get; set; }
        public IEnumerable<SelectListItem> GetDropdownListForSuffix { get; set; }

        public IEnumerable<SelectListItem> GetDropdownListForPosition { get; set; }

        public IEnumerable<SelectListItem> GetDropdownListForPackageName { get; set; }

        public IEnumerable<SelectListItem> GetDropdownListForPackageAmount { get; set; }

        public IEnumerable<SelectListItem> GetDropdownListForPackageDescription { get; set; }

        public IEnumerable<SelectListItem> GetDropdownListForAccessDate { get; set; }

        public IEnumerable<SelectListItem> GetDropdownListForAccessTime { get; set; }
    }
}

