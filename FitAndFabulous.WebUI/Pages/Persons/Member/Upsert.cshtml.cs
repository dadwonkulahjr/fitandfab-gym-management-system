using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.WebUI.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitAndFabulous.Utility;

namespace FitAndFabulous.WebUI.Pages.Persons.Member
{
    public class UpsertModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        [BindProperty]
        public MemberViewModel MemberViewModel { get; set; }
        public UpsertModel(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                MemberViewModel = new();

                MemberViewModel.GetDropdownListForGender = _context.Genders
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.Id.ToString(),
                                                            Text = x.Name
                                                        });


                MemberViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                MemberViewModel.GetDropdownListForPosition = _context.Positions
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Type
                                                         });

                MemberViewModel.GetDropdownListForGym = _context.Gyms
                                                  .Select(x => new SelectListItem()
                                                  {
                                                      Value = x.Id.ToString(),
                                                      Text = x.Name
                                                  });
                return Page();
            }


            if (id.HasValue)
            {
                MemberViewModel = new();
                MemberViewModel.Person = _context.Persons
                            .Include(x => x.Member)
                            .Include(x => x.Member.Gym)
                            .Include(x => x.Gender)
                            .Include(x => x.Suffix)
                            .FirstOrDefault(x => x.Id == id.Value);

                MemberViewModel.GetDropdownListForGender = _context.Genders
                                                             .Select(x => new SelectListItem()
                                                             {
                                                                 Value = x.Id.ToString(),
                                                                 Text = x.Name
                                                             });


                MemberViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                    .Select(x => new SelectListItem()
                                                    {
                                                        Value = x.Id.ToString(),
                                                        Text = x.Name
                                                    });


                MemberViewModel.GetDropdownListForPosition = _context.Positions
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.Id.ToString(),
                                                            Text = x.Type
                                                        });


                MemberViewModel.GetDropdownListForGym = _context.Gyms
                                                     .Select(x => new SelectListItem()
                                                     {
                                                         Value = x.Id.ToString(),
                                                         Text = x.Name
                                                     });

                if (MemberViewModel == null)
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
                MemberViewModel.GetDropdownListForGender = _context.Genders
                                                       .Select(x => new SelectListItem()
                                                       {
                                                           Value = x.Id.ToString(),
                                                           Text = x.Name
                                                       });


                MemberViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                MemberViewModel.GetDropdownListForPosition = _context.Positions
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.Id.ToString(),
                                                            Text = x.Type
                                                        });

                MemberViewModel.GetDropdownListForGym = _context.Gyms
                                                     .Select(x => new SelectListItem()
                                                     {
                                                         Value = x.Id.ToString(),
                                                         Text = x.Name
                                                     });
                return Page();
            }
            else
            {

                if (MemberViewModel != null)
                {
                    if (MemberViewModel.Person.Id == 0)
                    {
                        _context.Persons.Add(MemberViewModel.Person);
                        _context.SaveChanges();

                        TempData["success"] = $"{SDPosition.MEMBER} was added successfully!";
                        return RedirectToPage("list");

                    }
                    else
                    {
                        var memberFound = _context.Persons
                                        .Include(x => x.Member)
                                        .Include(x => x.Member.Gym)
                                        .FirstOrDefault(x => x.Id == MemberViewModel.Person.Id);

                        if (memberFound == null)
                        {
                            return NotFound();
                        }
                        else
                        {
                            //var result = _context.Attach<Person>(EmployeeViewModel.Person);
                            //result.State = EntityState.Modified;
                            memberFound.FirstName = MemberViewModel.Person.FirstName;
                            memberFound.MiddleName = MemberViewModel.Person.MiddleName;
                            memberFound.LastName = MemberViewModel.Person.LastName;
                            if (MemberViewModel.Person.Email != null)
                            {
                                memberFound.Email = MemberViewModel.Person.Email;
                            }
                            memberFound.Dob = MemberViewModel.Person.Dob;
                            memberFound.Address = MemberViewModel.Person.Address;
                            if (MemberViewModel.Person.Image != null)
                            {
                                memberFound.Image = MemberViewModel.Person.Image;
                            }

                            memberFound.Contact = MemberViewModel.Person.Contact;
                            memberFound.GenderId = MemberViewModel.Person.GenderId;
                            memberFound.PositionId = MemberViewModel.Person.PositionId;
                            memberFound.SuffixId = MemberViewModel.Person.SuffixId;
                            memberFound.Member.GymId = MemberViewModel.Person.Member.GymId;

                            _context.SaveChanges();
                            TempData["success"] = $"{SDPosition.MEMBER} was updated successfully!";
                            return RedirectToPage("list");
                        }
                    }

                }


            }
            return Page();
        }
    }
}
