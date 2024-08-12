using System;
using System.Collections.Generic;
using BuiTienThinh_22102363.DAO;
using BuiTienThinh_22102363.DTO;

namespace BuiTienThinh_22102363.BUS
{
    public class EmployeeBUS
    {
        private EmployeeDAO employeeDAO;

        public EmployeeBUS()
        {
            employeeDAO = new EmployeeDAO();
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAO.GetAll();
        }

        public List<Employee> SearchEmployees(string keyword)
        {
            return employeeDAO.SearchEmployees(keyword);
        }

        public void AddEmployee(Employee employee)
        {
            
            employeeDAO.Insert(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            
            employeeDAO.Update(employee);
        }

        public void DeleteEmployee(int employeeId)
        {
            
            employeeDAO.Delete(employeeId);
        }
        public Employee GetById(int id)
        {
            return employeeDAO.GetById(id);
        }
    }
}
