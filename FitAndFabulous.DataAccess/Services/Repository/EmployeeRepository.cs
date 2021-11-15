using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.DataAccess.Services.Repository.IRepository;
using FitAndFabulous.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository
{
    public class EmployeeRepository : DefaultRepository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EmployeeRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task UpdateGym(Employee employeeToUpdate)
        {
            var findEmployee = await _applicationDbContext.Employees.FirstOrDefaultAsync(e => e.Id == employeeToUpdate.Id, CancellationToken.None);

            if(findEmployee != null)
            {
                findEmployee.DateHire = employeeToUpdate.DateHire;
                findEmployee.OfficeEmail = employeeToUpdate.OfficeEmail;
                findEmployee.Salary = employeeToUpdate.Salary;
                findEmployee.Person.Id = employeeToUpdate.Person.Id;
            }
            
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
