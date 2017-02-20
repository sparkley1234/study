using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FactoryMethodExample
    {
        // 'IProduct' Interface
        interface IEmployee
    {
            void details();
        }

        // 'ConcreteProduct' class
        class PermanentEmployee : IEmployee
    {
            public void details()
            {
                Console.WriteLine("This is permanent employee type object");
            }
        }
        // 'ConcreteProduct' class
        class TemporaryEmployee : IEmployee
    {
            public void details()
            {
                Console.WriteLine("This is Temporary employee type object");
            }
        }

        class EmployeeFactory
        {
            public IEmployee Factory(Employee type)
            {
                switch (type)
                {
                    case Employee.PermanentEmployee:
                        return new PermanentEmployee();
                    case Employee.TemporaryEmployee:
                        return new TemporaryEmployee();
                    default:
                        throw new ApplicationException(string.Format("This type of employee can not be created"));
                }
            }
        }
    class EmployeeFactoryByReflection
    {
        public IEmployee Factory(Employee stype)
        {
            IEmployee IF = null;
            try
            {
                Type type = Type.GetType(stype.ToString());
                if (type != null)
                    return (IEmployee)Activator.CreateInstance(type);
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    type = asm.GetType("FactoryMethodExample.PermanentEmployee");
                    if (type != null)
                        return (IEmployee)Activator.CreateInstance(type);
                }
                return IF;
            }
            catch(Exception ex)
            {
                throw new ApplicationException(string.Format("This type of employee can not be created"));

            }            

        }
    }

    public enum Employee
    {
        PermanentEmployee,
        TemporaryEmployee
    }

    // factory method design pattern demo
    // calling class/ client
    class Program
        {
        //static void Main(string[] args)
        //{
        //    EmployeeFactory EF = new EmployeeFactory();
        //    IEmployee permanentEmployee = EF.Factory(Employee.PermanentEmployee);
        //    permanentEmployee.details();

        //    IEmployee temporaryEmployee = EF.Factory(Employee.TemporaryEmployee);
        //    temporaryEmployee.details();
        //    EmployeeFactoryByReflection EFR = new EmployeeFactoryByReflection();
        //    IEmployee permanentEmployeeByReflection = EFR.Factory(Employee.PermanentEmployee);

        //    Console.ReadLine();
        //}
    }
}

