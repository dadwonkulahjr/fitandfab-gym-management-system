using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.DataAccess.Services.Repository.IRepository;
using FitAndFabulous.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository
{
    public class GymRepository : DefaultRepository<Gym>, IGymRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public GymRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task UpdateGym(Gym gymToUpdate)
        {
            var findGym = await _applicationDbContext.Gyms.FirstOrDefaultAsync(g => g.Id == gymToUpdate.Id, CancellationToken.None);

            if (findGym != null)
            {
                findGym.Name = gymToUpdate.Name;
                findGym.Description = gymToUpdate.Description;
                if (gymToUpdate.Image != null)
                {
                    findGym.Image = gymToUpdate.Image;
                }

            }
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
