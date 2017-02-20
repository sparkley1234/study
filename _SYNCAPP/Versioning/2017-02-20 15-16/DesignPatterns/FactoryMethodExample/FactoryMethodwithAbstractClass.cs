using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    // 'IProduct' Interface
    //
   //It's really a matter of taste. Factory classes can be abstracted/interfaced away as necessary
    interface IIFactory
    {
        void details();
    }

    // 'ConcreteProduct' class
    class CPermanentEmployee : IIFactory
    {
        public void details()
        {
            Console.WriteLine("This is permanent employee type object");
        }
    }
    // 'ConcreteProduct' class
    class CTemporaryEmployee : IIFactory
    {
        public void details()
        {
            Console.WriteLine("This is Temporary employee type object");
        }
    }
    // 'Creator' abstract class
    abstract class CEmployeeFactory
    {
        public abstract IIFactory CFactory(string employeeType);
    }
    // 'ConcrteCreator' class
    class CConcreteEmployeeFactory : CEmployeeFactory
    {
        public override IIFactory CFactory(string CemployeeType)
        {
            switch (CemployeeType)
            {
                case "PermanentEmployee":
                    return new CPermanentEmployee();
                case "TemporaryEmployee":
                    return new CTemporaryEmployee();
                default:
                    throw new ApplicationException(string.Format("This type of employee can not be created"));
            }
        }
    }

    //
    class CReflectionConcreteEmployeeFactory : CEmployeeFactory
    {
        public override IIFactory CFactory(string CemployeeType)
        {
            switch (CemployeeType)
            {
                case "PermanentEmployee":
                    return new CPermanentEmployee();
                case "TemporaryEmployee":
                    return new CTemporaryEmployee();
                default:
                    throw new ApplicationException(string.Format("This type of employee can not be created"));
            }
        }
    }

    // factory method design pattern demo
    // calling class/ client
    class CProgram
    {
        //static void Main(string[] args)
        //{
        //    CEmployeeFactory CEmployeeFactory = new CConcreteEmployeeFactory();

        //    IIFactory permanentEmployee = CEmployeeFactory.CFactory("PermanentEmployee");
        //    permanentEmployee.details();

        //    IIFactory TemporaryEmployee = CEmployeeFactory.CFactory("TemporaryEmployee");
        //    TemporaryEmployee.details();

        //    Console.ReadLine();
        //}
    }
}
