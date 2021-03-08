using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Models;
using WinSoftTest_DL;

namespace WinSoftTest_BL.impl
{
    public class EmployeesBO : IEmployeesBO
    {
        private IEmployeesDAO _employeesDAO;

        public EmployeesBO(IEmployeesDAO _employeesDAO)
        {
            this._employeesDAO = _employeesDAO;
        }

        public List<DepartmentDTO> GetAllDepartments()
        {
            try
            {
                return _employeesDAO.GetAllDepartments();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<EmployeesDTO> GetDepartmentwiseEmployees(int DeptId)
        {
            try
            {
                return _employeesDAO.GetDepartmentwiseEmployees(DeptId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
