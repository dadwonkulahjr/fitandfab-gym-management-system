using FitAndFabulous.Models;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository.IRepository
{
    public interface IMemberRepository : IDefaultRepository<Member>
    {
        Task UpdateGym(Member memberToUpdate);
    }
}
