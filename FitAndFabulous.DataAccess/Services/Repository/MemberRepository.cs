using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.DataAccess.Services.Repository.IRepository;
using FitAndFabulous.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository
{
    public class MemberRepository : DefaultRepository<Member>, IMemberRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public MemberRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task UpdateGym(Member memberToUpdate)
        {
            var findMember = await _applicationDbContext.Members.FirstOrDefaultAsync(g => g.Id == memberToUpdate.Id, CancellationToken.None);

            if (findMember != null)
            {
                findMember.Description = memberToUpdate.Description;
                findMember.GymId = memberToUpdate.GymId;
                findMember.Id = memberToUpdate.Person.Id;
                await _applicationDbContext.SaveChangesAsync();
            }

        }
    }
}
