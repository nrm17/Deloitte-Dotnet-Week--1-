using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdaExample;

namespace linqExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee
                { EmpId = 100 , Name = "Martin" , Dept = "IT" , Salary = 3500 } ,
                 new Employee
                { EmpId = 101 , Name = "Martin Luther" , Dept = "ITIA" , Salary = 35000 } ,
                  new Employee
                { EmpId = 102 , Name = "Martin Luther King" , Dept = "IT" , Salary = 350000 } ,
                   new Employee
                { EmpId = 103 , Name = "Martin Luther King Jr." , Dept = "ITIAM" , Salary = 3500000 }


            };

            // select all data
            var data = from t in emp
            select t;

            foreach (var d in data)
            {
                Console.WriteLine(d.EmpId + " " + d.Name + " " + d.Dept + " " + d.Salary);

            }
            Console.WriteLine("*************************************");

            // select data based on id

            var data1 = (from t in emp
                        where t.EmpId == 100
                        select t).SingleOrDefault();

            if (data1 == null)
                Console.WriteLine("InvALID ID");
            else
                Console.WriteLine(data1.EmpId + " " + data1.Name + " " + data1.Dept + " " + data1.Salary);

            Console.WriteLine("*************************************");


            //select data based on multiple conditions

            var data2 = from t in emp
                        where t.Dept == "IT" && t.Salary > 50000
                        select t;

            foreach (var d in data2)
            {
                Console.WriteLine(d.EmpId + " " + d.Name + " " + d.Dept + " " + d.Salary);
            }
            Console.WriteLine("*************************************");

            // sort  name asc/desc and select only name

            var data3 = from t in emp
                        orderby t.Name ascending
                        select t.Name;

            foreach (var d in data3)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("*************************************");


            // print multiple data using anonymous types
            var data4 = from t in emp
                        select new { EmpName = t.Name, EmpSalary = t.Salary };

            foreach (var d in data4)
            {
                Console.WriteLine(d.EmpName + " " + d.EmpSalary);
            }

            Console.WriteLine("*************************************");


            // group by 

            var data5 = from t in emp
                        group t by t.Dept into grp
                        select new { DeptName = grp.Key, EmpCount = grp.Count(), SumSalary = grp.Sum(x => x.Salary) };

            foreach (var d in data5)
            {
                Console.WriteLine(d.DeptName + " " + d.EmpCount + " " + d.SumSalary);
            }
            Console.WriteLine("*************************************");


            // select emp getting max/min salary

            var data6 = from t in emp
                         where t.Salary == emp.Max(x => x.Salary)
                         select t;

            foreach (var d in data6)
            {
                Console.WriteLine(d.EmpId + " " + d.Name + " " + d.Dept + " " + d.Salary);
            }
            Console.WriteLine("*************************************");

            var data7 = from t in emp
                        where t.Salary == emp.Min(x => x.Salary)








                        select t;

            foreach (var d in data7)
            {
                Console.WriteLine(d.EmpId + " " + d.Name + " " + d.Dept + " " + d.Salary);
            }
            Console.WriteLine("*************************************");
        }
    }
}
