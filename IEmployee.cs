using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp
{
   public interface IEmployee<Employee>
    {
         List<Employee> getEmpList();
        bool AddEmployee(Employee e);
        bool RemoveEmployee(int id);
        Employee getEmpById(int id);

        string message(string name);
        bool checksal(int sal);

        int add(int x, int y);
        

    }
}
