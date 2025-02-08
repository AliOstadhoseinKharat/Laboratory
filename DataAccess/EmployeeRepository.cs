using DataAccess.services;
using DomainModel.Models;
using DomainModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private LabotatoryContext2 _context = new LabotatoryContext2();
        public int Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee.EmployeeID;
        }

        public Employee Get(int id)
        {
            return _context.Employees.FirstOrDefault(item => item.EmployeeID == id);
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.OrderByDescending(item => item.EmployeeID).ToList();
        }

        public List<EmployeeViewModel> GetAllEmployee()
        {
            List<EmployeeViewModel> employeeViews =
                _context.Employees.Select(item => new EmployeeViewModel
                {
                    EmployeeID = item.EmployeeID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    FullName = (item.FirstName ?? "") + " " + (item.LastName ?? ""),
                    UserName = item.UserName,
                    Password = item.Password,
                    Mobile = item.Mobile,

                }).ToList();

            return employeeViews;
        }

        public bool Remove(int employeeID)
        {
            bool result = false;
            try
            {
                Employee employeeFounded = _context.Employees.FirstOrDefault(item =>
                item.EmployeeID == employeeID);

                _context.Employees.Remove(employeeFounded);
                _context.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool Update(Employee newEmployee)
        {
            try
            {
                Employee oldEmployee = _context.Employees.FirstOrDefault(item => item.EmployeeID ==
                newEmployee.EmployeeID);

                oldEmployee.FirstName = newEmployee.FirstName;
                oldEmployee.LastName = newEmployee.LastName;
                oldEmployee.UserName = newEmployee.UserName;
                oldEmployee.Password = newEmployee.Password;
                oldEmployee.Mobile = newEmployee.Mobile;


                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
