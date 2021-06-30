using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IEmployeeRepository : IRepositoryBase<Employee>
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(Guid IdOwner);
        void CreateEmployee(Employee owner);
        void UpdateEmployee(Employee owner);
        void DeleteEmployee(Employee owner);
    }
}
