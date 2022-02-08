using HMS_DAL.Repository;
using HMS_Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS_BAL.Services
{
     public class EmployeeServices
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void AddEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }
        public void DeleteEmployee(int EmployeeId)
        {
            _employeeRepository.DeleteEmployee(EmployeeId);
        }
        public void GetEmployeeById(int EmployeeId)
        {
            _employeeRepository.GetEmployeeById(EmployeeId);
        }
        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetEmployees();


        }
    }
}
