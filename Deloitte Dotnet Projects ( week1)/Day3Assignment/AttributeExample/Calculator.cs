using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{

    [DevInfo(EmpId =123,DateOfCreation ="07/17/2018",ProjName ="Banking",Message ="This class calculator is used to perform calculation through 4 method Add ,sub,mul,div")]
    class Calculator
    {

        [DevInfo(EmpId = 123, DateOfCreation = "07/17/2018", ProjName = "Banking", Message = "This class calculator is used to perform calculation through 4 method Add ,sub,mul,div")]

        public int Add(int x, int y)
        {
            return (x + y);
        }
        public int Sub(int x, int y)
        {
            return (x - y);
        }
        public int Mul(int x, int y)
        {
            return (x * y);
        }
        public int Div(int x, int y)
        {
            return (x / y);
        }
    }
}
