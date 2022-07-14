using System;
using System.Collections.Generic;

namespace EmpApp
{
    class Program //client application
    {
        public static List<Employee> emps = new List<Employee>();
        static void Main(string[] args)
        {
            
            IEmployee<Employee> obj = new Employee();
            int result=obj.add(5, 4);
            Console.WriteLine(result);
            //emps=obj.getEmpList();
            Employee e1=obj.getEmpById(1);
            Console.WriteLine(e1.Ename + " " + e1.Salary);
        }
    }
}
