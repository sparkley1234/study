using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeSOLID
{
    public abstract class EmployeeLSP
    {
    public virtual string GetProjectDetails(int employeeId)
    {
        return "Base Project";
    }
    public virtual string GetEmployeeDetails(int employeeId)
    {
        return "Base Employee";
    }
}
public class CasualEmployee : EmployeeLSP
    {
    public override string GetProjectDetails(int employeeId)
    {
        return "Child Project";
    }
    
    public override string GetEmployeeDetails(int employeeId)
    {
        return "Child Employee";
    }
}
public class ContractualEmployee : EmployeeLSP
    {
    public override string GetProjectDetails(int employeeId)
    {
        return "Child Project";
    }
    // May be for contractual employee we do not need to store/view the details into database.
    public override string GetEmployeeDetails(int employeeId)
    {
        throw new NotImplementedException();
            //Duck , Fly not available a classical example :)
    }
}
}
