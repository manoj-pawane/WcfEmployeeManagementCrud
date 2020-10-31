using Common.Contracts;
using System.Collections.Generic;

namespace RepositoryManager.Interface
{
    public interface IEmployeeRepository
    {
        IList<EmployeeContract> GetAllEmployee();

        int AddEmployee(EmployeeContract employeeContract);

        int UpdateEmployee(EmployeeContract employeeContract, int EmpId);

        EmployeeContract GetById(int empId);

        int DeleteEmployee(int empId);

        EmployeeContract GetEmployeeByEmail(string email);
    }
}




