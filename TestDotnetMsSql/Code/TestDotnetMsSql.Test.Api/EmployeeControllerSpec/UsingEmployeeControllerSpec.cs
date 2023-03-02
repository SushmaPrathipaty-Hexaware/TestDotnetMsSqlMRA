using NSubstitute;
using TestDotnetMsSql.Test.Framework;
using TestDotnetMsSql.Api.Controllers;
using TestDotnetMsSql.Business.Interfaces;


namespace TestDotnetMsSql.Test.Api.EmployeeControllerSpec
{
    public abstract class UsingEmployeeControllerSpec : SpecFor<EmployeeController>
    {
        protected IEmployeeService _employeeService;

        public override void Context()
        {
            _employeeService = Substitute.For<IEmployeeService>();
            subject = new EmployeeController(_employeeService);

        }

    }
}
