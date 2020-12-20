using LN.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN.DbContext.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        private Smart_FieldManagementEntities db = new Smart_FieldManagementEntities();
        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO();
                return instance;
            }
        }
        //Get Employee List
        public List<Employee> listEmployees()
        {
            return db.Employees.ToList();
        }

    }
}
