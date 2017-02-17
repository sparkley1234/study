using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeLSP> employeeList = new List<EmployeeLSP>();
            employeeList.Add(new CasualEmployee());
            employeeList.Add(new ContractualEmployee());
            foreach (EmployeeLSP e in employeeList)
            {
                e.GetEmployeeDetails(1245);
            }
        }
    }
}
