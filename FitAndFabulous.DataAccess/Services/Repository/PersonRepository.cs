using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.DataAccess.Services.Repository.IRepository;
using FitAndFabulous.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository
{
    public class PersonRepository : DefaultRepository<Person>, IPersonRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PersonRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task UpdateGym(Person personToUpdate)
        {
            var findPerson= await _applicationDbContext.Persons.FirstOrDefaultAsync(g => g.Id == personToUpdate.Id, CancellationToken.None);

            if (findPerson != null)
            {
                findPerson.FirstName = personToUpdate.FirstName;
                findPerson.MiddleName = personToUpdate.MiddleName;
                findPerson.LastName = personToUpdate.LastName;
                findPerson.Email = personToUpdate.Email;
                findPerson.Dob = personToUpdate.Dob;
                findPerson.Address = personToUpdate.Address;
                findPerson.Contact = personToUpdate.Contact;
                findPerson.GenderId = personToUpdate.GenderId;
                findPerson.SuffixId = personToUpdate.SuffixId;
                findPerson.PositionId = personToUpdate.PositionId;

                if (personToUpdate.Image != null)
                {
                    findPerson.Image = personToUpdate.Image;
                }
                await _applicationDbContext.SaveChangesAsync();
            }
           
        }
    }
}
