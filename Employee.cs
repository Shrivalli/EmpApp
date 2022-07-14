using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp
{
    public class Employee:IEmployee<Employee>
    {
        public int Eid { get; set; }
        public String Ename { get; set; }
        public float Salary { get; set; }

        public Employee() { }

        public Employee(int eid,string ename, float sal)
        {
            Eid = eid;
            Ename = ename;
            Salary = sal;
        }

        public static List<Employee> employees = new List<Employee>();

        
        public  List<Employee> getEmpList()
        {
            employees.Add(new Employee(1, "John", 25000));
            employees.Add(new Employee(2, "Siddharth", 60000));
            return employees;
        }

        public bool AddEmployee(Employee e)
        {
            employees.Add(e);
            return true;
        }

        public bool checksal(int sal)
        {
            int result=add(sal, 20);
            if (result > 50)
                return true;
            else
                return false;
        }

        public int add(int a, int b)
        {
            return a + b;
        }
        public Employee getEmpById(int id)
        {
            employees = getEmpList();
            Employee e = employees.Where(x => x.Eid == id).SingleOrDefault();
            return e;
        }

        
        public string message(string name)
        {
            return "Hello " + name;
        }

        public bool RemoveEmployee(int id)
        {
            Employee e=getEmpById(id);
            employees.Remove(e);
                return true;
        }
    }
}
