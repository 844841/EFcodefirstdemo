using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcodefirstdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //insertdata();

            //ShowallEmployees();

            // updatebyID();

            //  ShowdataID(n);

            DeletedById();

        }

        private static void DeletedById()
        {
            EmployeeContext em = new EmployeeContext();
            Console.WriteLine("enter employee id by search");
            int id = Convert.ToInt32(Console.ReadLine());
            em.Employees.Remove(em.Employees.Find(id));
            em.SaveChanges();
            Console.WriteLine("deleted successfully");
        }

        private static void updatebyID()
        {
            EmployeeContext ecx = new EmployeeContext();
            Console.WriteLine("enter empid to search");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter new salary");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter new designation");
            string des = Console.ReadLine();
            var employees = ecx.Employees;

            var emp = from e in employees
                      where e.Eid == id
                      select e;
            foreach (var e in employees)
            {
                e.Salary = sal;
                e.Designation = des;
            }
            ecx.SaveChanges();
        }

        private static void ShowdataID(int id)
        {
            EmployeeContext em = new EmployeeContext();
            Console.WriteLine("enter id");
            var employees = from e in em.Employees
                            where e.Eid == id
                            select e;
            foreach (var q in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", q.Eid, q.Ename, q.Designation, q.Salary);
            }
        }





        private static void ShowallEmployees()
        {
            EmployeeContext empctx = new EmployeeContext();
            var employees = empctx.Employees;
            foreach (var emp in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Eid, emp.Ename,
                    emp.Designation, emp.Salary);

            }
        }

        private static void insertdata()
        {
            EmployeeContext ect = new EmployeeContext();

            Console.WriteLine("Enter employee name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter designation");
            string desg = Console.ReadLine();
            Console.WriteLine("Enter salary");
            double sal = Convert.ToDouble(Console.ReadLine());
            ect.Employees.Add(new Employee
            {
                Ename = name,
                Designation = desg,
                Salary = sal
            });
            ect.SaveChanges();
        }
    }
}
