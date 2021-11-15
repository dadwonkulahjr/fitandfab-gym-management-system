using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.Utility;
using FitAndFabulous.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FitAndFabulous.WebUI.Pages.Persons.Trainer
{
    public class UpsertModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public TrainerViewModel TrainerViewModel { get; set; }
        public UpsertModel(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                TrainerViewModel = new();

                TrainerViewModel.GetDropdownListForGender = _context.Genders
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.Id.ToString(),
                                                            Text = x.Name
                                                        });


                TrainerViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                TrainerViewModel.GetDropdownListForPosition = _context.Positions
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Type
                                                         });

                
                return Page();
            }


            if (id.HasValue)
            {
                TrainerViewModel = new();
                TrainerViewModel.Person = _context.Persons
                            .Include(x => x.Member)
                            .Include(x => x.Member.Gym)
                            .Include(x => x.Gender)
                            .Include(x => x.Suffix)
                            .FirstOrDefault(x => x.Id == id.Value);

                TrainerViewModel.GetDropdownListForGender = _context.Genders
                                                             .Select(x => new SelectListItem()
                                                             {
                                                                 Value = x.Id.ToString(),
                                                                 Text = x.Name
                                                             });


                TrainerViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                    .Select(x => new SelectListItem()
                                                    {
                                                        Value = x.Id.ToString(),
                                                        Text = x.Name
                                                    });


                TrainerViewModel.GetDropdownListForPosition = _context.Positions
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.Id.ToString(),
                                                            Text = x.Type
                                                        });


                if (TrainerViewModel == null)
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
                TrainerViewModel.GetDropdownListForGender = _context.Genders
                                                       .Select(x => new SelectListItem()
                                                       {
                                                           Value = x.Id.ToString(),
                                                           Text = x.Name
                                                       });


                TrainerViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                TrainerViewModel.GetDropdownListForPosition = _context.Positions
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.Id.ToString(),
                                                            Text = x.Type
                                                        });

                return Page();
            }
            else
            {

                if (TrainerViewModel != null)
                {
                    if (TrainerViewModel.Person.Id == 0)
                    {
                        _context.Persons.Add(TrainerViewModel.Person);
                        _context.SaveChanges();

                        TempData["success"] = $"{SDPosition.TRAINER} was added successfully!";
                        return RedirectToPage("list");

                    }
                    else
                    {
                        var memberFound = _context.Persons
                                        .Include(x => x.Member)
                                        .Include(x => x.Member.Gym)
                                        .FirstOrDefault(x => x.Id == TrainerViewModel.Person.Id);

                        if (memberFound == null)
                        {
                            return NotFound();
                        }
                        else
                        {
                            //var result = _context.Attach<Person>(EmployeeViewModel.Person);
                            //result.State = EntityState.Modified;
                            memberFound.FirstName = TrainerViewModel.Person.FirstName;
                            memberFound.MiddleName = TrainerViewModel.Person.MiddleName;
                            memberFound.LastName = TrainerViewModel.Person.LastName;
                            if (TrainerViewModel.Person.Email != null)
                            {
                                memberFound.Email = TrainerViewModel.Person.Email;
                            }
                            memberFound.Dob = TrainerViewModel.Person.Dob;
                            memberFound.Address = TrainerViewModel.Person.Address;
                            if (TrainerViewModel.Person.Image != null)
                            {
                                memberFound.Image = TrainerViewModel.Person.Image;
                            }

                            memberFound.Contact = TrainerViewModel.Person.Contact;
                            memberFound.GenderId = TrainerViewModel.Person.GenderId;
                            memberFound.PositionId = TrainerViewModel.Person.PositionId;
                            memberFound.SuffixId = TrainerViewModel.Person.SuffixId;

                            _context.SaveChanges();
                            TempData["success"] = $"{SDPosition.TRAINER} was updated successfully!";
                            return RedirectToPage("list");
                        }
                    }

                }


            }
            return Page();
        }
    }
}
