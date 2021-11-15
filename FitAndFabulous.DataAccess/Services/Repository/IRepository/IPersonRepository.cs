using FitAndFabulous.Models;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository.IRepository
{
    public interface IPersonRepository : IDefaultRepository<Person>
    {
        Task UpdateGym(Person personToUpdate);
    }
}
