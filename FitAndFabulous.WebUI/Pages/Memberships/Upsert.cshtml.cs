using System.Linq;
using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.Utility;
using FitAndFabulous.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FitAndFabulous.WebUI.Pages.Memberships
{
    public class UpsertModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public MembershipViewModel MembershipViewModel { get; set; }
        public UpsertModel(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                MembershipViewModel = new();

                MembershipViewModel.GetDropdownListForGender = _context.Genders
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.Id.ToString(),
                                                            Text = x.Name
                                                        });


                MembershipViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                MembershipViewModel.GetDropdownListForPosition = _context.Positions
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Type
                                                         });

                MembershipViewModel.GetDropdownListForPerson = _context.Persons
                                                                       .Select(x => new SelectListItem()
                                                                       {
                                                                           Text = x.FullName,
                                                                           Value = x.Id.ToString()
                                                                       });

                MembershipViewModel.GetDropdownListForPackageName = _context.Packages
                                                                    .Select(x => new SelectListItem()
                                                                    {
                                                                        Text = x.Name,
                                                                        Value = x.Id.ToString()
                                                                    });

                MembershipViewModel.GetDropdownListForPackageAmount = _context.Packages
                                                                   .Select(x => new SelectListItem()
                                                                   {
                                                                       Text = x.Amount.ToString("c"),
                                                                       Value = x.Id.ToString()
                                                                   });


                MembershipViewModel.GetDropdownListForPackageDescription = _context.Packages
                                                                  .Select(x => new SelectListItem()
                                                                  {
                                                                      Text = x.Description,
                                                                      Value = x.Id.ToString()
                                                                  });

                MembershipViewModel.GetDropdownListForAccessDate = _context.AccessDays
                                                               .Select(x => new SelectListItem()
                                                               {
                                                                   Text = x.Date.ToShortDateString(),
                                                                   Value = x.Id.ToString()
                                                               });

                MembershipViewModel.GetDropdownListForAccessTime = _context.AccessDays
                                                              .Select(x => new SelectListItem()
                                                              {
                                                                  Text = x.Time.ToString(),
                                                                  Value = x.Id.ToString()
                                                              });


                return Page();
            }


            if (id.HasValue)
            {
                MembershipViewModel = new();
                MembershipViewModel.Membership = _context.Memberships
                            .Include(x => x.Person)
                            .Include(x => x.Person.Gender)
                            .Include(x => x.Person.Position)
                            .Include(x => x.Person.Suffix)
                            .Include(x => x.Package)
                            .Include(x => x.AccessDays)
                            .FirstOrDefault(x => x.Id == id.Value);

                MembershipViewModel.GetDropdownListForGender = _context.Genders
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                MembershipViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                MembershipViewModel.GetDropdownListForPosition = _context.Positions
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Type
                                                         });

                MembershipViewModel.GetDropdownListForPerson = _context.Persons
                                                                       .Select(x => new SelectListItem()
                                                                       {
                                                                           Text = x.FullName,
                                                                           Value = x.Id.ToString()
                                                                       });

                MembershipViewModel.GetDropdownListForPackageName = _context.Packages
                                                                    .Select(x => new SelectListItem()
                                                                    {
                                                                        Text = x.Name,
                                                                        Value = x.Id.ToString()
                                                                    });

                MembershipViewModel.GetDropdownListForPackageAmount = _context.Packages
                                                                   .Select(x => new SelectListItem()
                                                                   {
                                                                       Text = x.Amount.ToString("c"),
                                                                       Value = x.Id.ToString()
                                                                   });


                MembershipViewModel.GetDropdownListForPackageDescription = _context.Packages
                                                                  .Select(x => new SelectListItem()
                                                                  {
                                                                      Text = x.Description,
                                                                      Value = x.Id.ToString()
                                                                  });

                MembershipViewModel.GetDropdownListForAccessDate = _context.AccessDays
                                                               .Select(x => new SelectListItem()
                                                               {
                                                                   Text = x.Date.ToShortDateString(),
                                                                   Value = x.Id.ToString()
                                                               });

                MembershipViewModel.GetDropdownListForAccessTime = _context.AccessDays
                                                              .Select(x => new SelectListItem()
                                                              {
                                                                  Text = x.Time.ToString(),
                                                                  Value = x.Id.ToString()
                                                              });


                if (MembershipViewModel == null)
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
                MembershipViewModel.GetDropdownListForGender = _context.Genders
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                MembershipViewModel.GetDropdownListForSuffix = _context.Suffixes
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Name
                                                         });


                MembershipViewModel.GetDropdownListForPosition = _context.Positions
                                                         .Select(x => new SelectListItem()
                                                         {
                                                             Value = x.Id.ToString(),
                                                             Text = x.Type
                                                         });

                MembershipViewModel.GetDropdownListForPerson = _context.Persons
                                                                       .Select(x => new SelectListItem()
                                                                       {
                                                                           Text = x.FullName,
                                                                           Value = x.Id.ToString()
                                                                       });

                MembershipViewModel.GetDropdownListForPackageName = _context.Packages
                                                                    .Select(x => new SelectListItem()
                                                                    {
                                                                        Text = x.Name,
                                                                        Value = x.Id.ToString()
                                                                    });

                MembershipViewModel.GetDropdownListForPackageAmount = _context.Packages
                                                                   .Select(x => new SelectListItem()
                                                                   {
                                                                       Text = x.Amount.ToString("c"),
                                                                       Value = x.Id.ToString()
                                                                   });


                MembershipViewModel.GetDropdownListForPackageDescription = _context.Packages
                                                                  .Select(x => new SelectListItem()
                                                                  {
                                                                      Text = x.Description,
                                                                      Value = x.Id.ToString()
                                                                  });

                MembershipViewModel.GetDropdownListForAccessDate = _context.AccessDays
                                                               .Select(x => new SelectListItem()
                                                               {
                                                                   Text = x.Date.ToShortDateString(),
                                                                   Value = x.Id.ToString()
                                                               });

                MembershipViewModel.GetDropdownListForAccessTime = _context.AccessDays
                                                              .Select(x => new SelectListItem()
                                                              {
                                                                  Text = x.Time.ToString(),
                                                                  Value = x.Id.ToString()
                                                              });

                return Page();
            }
            else
            {

                if (MembershipViewModel != null)
                {
                    if (MembershipViewModel.Membership.Id == 0)
                    {
                        _context.Persons.Add(MembershipViewModel.Membership.Person);
                        _context.SaveChanges();

                        TempData["success"] = $"{SDPosition.MEMBERSHIP} was added successfully!";
                        return RedirectToPage("list");

                    }
                    else
                    {
                        var memberFound = _context.Memberships
                                         .Include(x => x.Person)
                                         .Include(x => x.Person.Gender)
                                         .Include(x => x.Person.Position)
                                         .Include(x => x.Person.Suffix)
                                         .Include(x => x.Package)
                                         .Include(x => x.AccessDays)
                                         .FirstOrDefault(x => x.Id == MembershipViewModel.Membership.Id);

                        if (memberFound == null)
                        {
                            return NotFound();
                        }
                        else
                        {
                            //var result = _context.Attach<Person>(EmployeeViewModel.Person);
                            //result.State = EntityState.Modified;
                            memberFound.Person.FirstName = MembershipViewModel.Membership.Person.FirstName;
                            memberFound.Person.MiddleName = MembershipViewModel.Membership.Person.MiddleName;
                            memberFound.Person.LastName = MembershipViewModel.Membership.Person.LastName;
                            if (MembershipViewModel.Membership.Person.Email != null)
                            {
                                memberFound.Person.Email = MembershipViewModel.Membership.Person.Email;
                            }
                            memberFound.Person.Dob = MembershipViewModel.Membership.Person.Dob;
                            memberFound.Person.Address = MembershipViewModel.Membership.Person.Address;
                            if (MembershipViewModel.Membership.Person.Image != null)
                            {
                                memberFound.Person.Image = MembershipViewModel.Membership.Person.Image;
                            }

                            memberFound.Person.Contact = MembershipViewModel.Membership.Person.Contact;
                            memberFound.Person.GenderId = MembershipViewModel.Membership.Person.GenderId;
                            memberFound.Person.PositionId = MembershipViewModel.Membership.Person.PositionId;
                            memberFound.Person.SuffixId = MembershipViewModel.Membership.Person.SuffixId;
                            memberFound.AccessDaysId = MembershipViewModel.Membership.AccessDaysId;
                            memberFound.PackageId = MembershipViewModel.Membership.PackageId;
                            memberFound.PersonId = MembershipViewModel.Membership.PersonId;
                            memberFound.DateCreated = MembershipViewModel.Membership.DateCreated;
                            memberFound.ExpiryDate = MembershipViewModel.Membership.ExpiryDate;
                            memberFound.Name = MembershipViewModel.Membership.Name;
                            memberFound.Status = MembershipViewModel.Membership.Status;
                            _context.SaveChanges();
                            TempData["success"] = $"{SDPosition.MEMBERSHIP} was updated successfully!";
                            return RedirectToPage("list");
                        }
                    }

                }


            }
            return Page();
        }
    }
}
