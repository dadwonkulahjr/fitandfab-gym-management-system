using FitAndFabulous.Models;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository.IRepository
{
    public interface IEmployeeRepository : IDefaultRepository<Employee>
    {
        Task UpdateGym(Employee employeeToUpdate);
    }
}
