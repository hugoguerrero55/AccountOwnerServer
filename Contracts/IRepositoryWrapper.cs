using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IOwnerRepository Owner { get; }
        IAccountRepository Account { get; }
        IEmployeeRepository Employee { get; }
        Task SaveAsync();
    }
}
