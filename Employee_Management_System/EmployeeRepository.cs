using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees = new List<Employee>();
        private int _nextEmployeeId = 1;

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employees;
        }

        public Employee GetEmployeeById(int employeeId) => _employees.FirstOrDefault(e => e.EmployeeId == employeeId);

        void IEmployeeRepository.AddEmployee(Employee employee)
        {
            employee.EmployeeId = _nextEmployeeId++;
            _employees.Add(employee);
        }

    }
}
