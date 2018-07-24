using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {

            // lambda with array

            int[] arr = { 0, -1, 4, 5, 6, 9, -2, 3, 2, 10 };
            foreach (var a in arr.Where(n => n > 5))
                Console.WriteLine(a);
            string[] cities = { "Mumbai", "Chennai ", " Bengaluru", "Pune", "Patna" };
            foreach (var c in cities.Where(g => g.StartsWith("P")))
                Console.WriteLine(c);

            foreach (var d in cities.Where(y => y.Contains("e")))
                Console.WriteLine(d);


            var result = cities.Where(x => x.Contains("e"));
            Console.WriteLine(result.Count());

            // Lambda with collection

            // 3.5 collection initialzier

            // adding to colletion without using add collection

            List<Employee> emp = new List<Employee>
            {
                new Employee
                { EmpId = 100 , Name = "Martin" , Dept = "IT" , Salary = 3500 } ,
                 new Employee
                { EmpId = 101 , Name = "Martin Luther" , Dept = "IT" , Salary = 35000 } ,
                  new Employee
                { EmpId = 102 , Name = "Martin Luther King" , Dept = "ITIA" , Salary = 350000 } ,
                   new Employee
                { EmpId = 103 , Name = "Martin Luther King Jr." , Dept = "ITIAM" , Salary = 3500000 } 


            };

            // display all values

            foreach (var r in emp)
                Console.WriteLine(r.EmpId + " " + " " + r.Name + " " + r.Dept + " " + r.Salary);


            var data = emp.Where(x => x.EmpId == 100).SingleOrDefault();
            if (data == null)
                Console.WriteLine("Invalid emp id");
            else
                Console.WriteLine(data.EmpId + " " + data.Name + " " + data.Dept + " " + data.Salary);

            var dat = emp.Where(x => x.Dept == "IT");
            if(dat.Count()==0)
            {
                Console.WriteLine("Invalid dept name");

            }

            else
            {
                foreach( var r in dat)
                {
                    Console.WriteLine(r.EmpId + " " + r.Name + " " + r.Dept);
                }
            }


            // SELECT NAME SORTED IN ASC/DESC ORDER OF NAME

            var data2 = emp.OrderBy(x => x.Name).Select(y => y.Name);
            foreach (var d in data2)
                Console.Write(d);

            var data3 = emp.OrderByDescending(x => x.Name).Select(y => y.Name);
            foreach (var d in data3)
                Console.WriteLine(d);

            // Select - selects one property or it will select all properties
            // to Select name nad salary we used - Anonymous property
            // new { EmpName = e.Name , EmpSalary = e.Salary}


            var data5 = emp.Select(x => new { EmpName = x.Name, EmpSalary = x.Salary });
            foreach (var d in data5)
                Console.WriteLine(d.EmpName + " " + d.EmpSalary);


            // SUMMARY - COUNT OF EMPLOYESS DEPT WISE AND SUM OF SALARY PAID DEPT WISE

            // column on which thae group by is provided
            var grp = emp.GroupBy(x => x.Dept).Select(x => new { DeptName = x.Key, EmpCount = x.Count(), sumSalary = x.Sum(y => y.Salary) });

            foreach (var g in grp)
                Console.WriteLine(g.DeptName + "  " + g.EmpCount + "  " + g.sumSalary);


            Console.WriteLine("Max salary : " + emp.Max(x => x.Salary));
            Console.WriteLine("Min salary : " + emp.Min(x => x.Salary));


            var maxsal = emp.Where(x => x.Salary == emp.Max(y => y.Salary));

            foreach( var d in maxsal)
                Console.WriteLine(d.Name + " " + d.Salary);




        }
    }
}
