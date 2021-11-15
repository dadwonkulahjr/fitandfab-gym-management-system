using System;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveDataToDb();
        public IGymRepository Gym { get; }
        public IPersonRepository Person { get; }

        public IEmployeeRepository Employee { get; }

        public IMemberRepository Member { get; }
    }
}
