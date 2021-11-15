using FitAndFabulous.DataAccess.Data;
using FitAndFabulous.DataAccess.Services.Repository.IRepository;
using System;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            Gym = new GymRepository(applicationDbContext);
            Person = new PersonRepository(applicationDbContext);
            Employee = new EmployeeRepository(applicationDbContext);
            Member = new MemberRepository(applicationDbContext);
        }

        public IGymRepository Gym { get; private set; }
        public IPersonRepository Person { get; private set; }

        public IEmployeeRepository Employee { get; private set; }

        public IMemberRepository Member { get; private set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task SaveDataToDb()
        {
            await _context.SaveChangesAsync();
        }
    }
}
