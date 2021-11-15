using System.Collections.Generic;
using System.Linq;
using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FitAndFabulous.WebUI.Pages.Persons.Employee
{
    //[BindProperties]
    public class UpsertModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public UpsertModel(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        [BindProperty]
        public EmployeeViewModel EmployeeViewModel { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                EmployeeViewModel = new();

                EmployeeViewModel.GetDropdownListForGender = _context.Genders
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.Id.ToString(),
                                                            Text = x.Name
                                                        });


                EmployeeViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                EmployeeViewModel.GetDropdownListForPosition = _context.Positions
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Type
                                                         });
                return Page();
            }


            if (id.HasValue)
            {
                EmployeeViewModel = new();
                EmployeeViewModel.Person = _context.Persons
                            .Include(x => x.Employee)
                            .Include(x => x.Gender)
                            .Include(x => x.Suffix)
                            .FirstOrDefault(x => x.Id == id.Value);

                EmployeeViewModel.GetDropdownListForGender = _context.Genders
                                                             .Select(x => new SelectListItem()
                                                             {
                                                                 Value = x.Id.ToString(),
                                                                 Text = x.Name
                                                             });


                EmployeeViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                    .Select(x => new SelectListItem()
                                                    {
                                                        Value = x.Id.ToString(),
                                                        Text = x.Name
                                                    });


                EmployeeViewModel.GetDropdownListForPosition = _context.Positions
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.Id.ToString(),
                                                            Text = x.Type
                                                        });

                if (EmployeeViewModel == null)
                {
                    return NotFound();
                }

                return Page();
            }

            return Page();
        }


        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                EmployeeViewModel.GetDropdownListForGender = _context.Genders
                                                       .Select(x => new SelectListItem()
                                                       {
                                                           Value = x.Id.ToString(),
                                                           Text = x.Name
                                                       });


                EmployeeViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                EmployeeViewModel.GetDropdownListForPosition = _context.Positions
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.Id.ToString(),
                                                            Text = x.Type
                                                        });
                return Page();
            }
            else
            {

                if (EmployeeViewModel != null)
                {
                    if (EmployeeViewModel.Person.Id == 0)
                    {
                        _context.Persons.Add(EmployeeViewModel.Person);
                        _context.SaveChanges();

                        TempData["success"] = "Employee was added successfully!";
                        return RedirectToPage("list");

                    }
                    else
                    {
                        var empFound = _context.Persons
                                        .Include(x => x.Employee)
                                        .FirstOrDefault(x => x.Id == EmployeeViewModel.Person.Id);

                        if (empFound == null)
                        {
                            return NotFound();
                        }
                        else
                        {
                            //var result = _context.Attach<Person>(EmployeeViewModel.Person);
                            //result.State = EntityState.Modified;
                            empFound.FirstName = EmployeeViewModel.Person.FirstName;
                            empFound.MiddleName = EmployeeViewModel.Person.MiddleName;
                            empFound.LastName = EmployeeViewModel.Person.LastName;
                            empFound.Dob = EmployeeViewModel.Person.Dob;
                            empFound.Address = EmployeeViewModel.Person.Address;
                            if (EmployeeViewModel.Person.Image != null)
                            {
                                empFound.Image = EmployeeViewModel.Person.Image;
                            }

                            empFound.Contact = EmployeeViewModel.Person.Contact;
                            empFound.GenderId = EmployeeViewModel.Person.GenderId;
                            empFound.PositionId = EmployeeViewModel.Person.PositionId;
                            empFound.SuffixId = EmployeeViewModel.Person.SuffixId;

                            if (EmployeeViewModel.Person.Employee.OfficeEmail != null)
                            {
                                empFound.Employee.OfficeEmail =         EmployeeViewModel.Person.Employee.OfficeEmail;
                            }

                            empFound.Employee.Salary = EmployeeViewModel.Person.Employee.Salary;

                            _context.SaveChanges();
                            TempData["success"] = "Employee was updated successfully!";
                            return RedirectToPage("list");
                        }
                    }

                }


            }
            return Page();
        }
    }
}
