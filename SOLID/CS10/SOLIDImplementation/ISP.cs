using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDImplementation
{
    /// <summary>
    /// Now suppose that company one day told to you that they want to read only data of permanent employees.
    /// What you will do, just add one method to this interface?But now we are breaking something.
    /// We are forcing non-permanent employee class to show their details from database.
    /// So, the solution is to give this responsibility to another interface.
    /// </summary>
    class ISP
    {
    }
    public interface IAddOperation
    {
        bool AddEmployeeDetails();
    }
    public interface IGetOperation
    {
        string ShowEmployeeDetails(int employeeId);
    }
    public class ContractualEmployeeISP : IAddOperation
    {
        public bool AddEmployeeDetails()
        {
            return true;
        }
        ///We dont need to show ContractualEmployeeISP details so, we havn't 
    }
    public class CasualEmployeeISP : IAddOperation, IGetOperation
    {
        public bool AddEmployeeDetails()
        {
            return true;
        }

        public string ShowEmployeeDetails(int employeeId)
        {
            return "CasualEmployeeISP Employee";
        }
    }
    

    
}
