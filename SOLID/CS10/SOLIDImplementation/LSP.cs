using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDImplementation
{

    public interface IEmployeeLSP
    {
        string GetEmployeeDetails(int employeeId);
    }

    public interface IProjectLSP
    {
        string GetProjectDetails(int employeeId);
    }
    public class CasualEmployee : IEmployeeLSP, IProjectLSP
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "EmployeeDetails for CasualEmployee";
        }

        public string GetProjectDetails(int employeeId)
        {
            return "Child Project for CasualEmployee";
        }
    }
    public class ContractualEmployee : IProjectLSP
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Child Project for ContractualEmployee";
        }
    }
}
