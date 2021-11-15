using FitAndFabulous.Models;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository.IRepository
{
    public interface IGymRepository : IDefaultRepository<Gym>
    {
        Task UpdateGym(Gym gymToUpdate);
    }
}
