using NSubstitute;
using TestDotnetMsSql.Test.Framework;
using TestDotnetMsSql.Business.Services;
using TestDotnetMsSql.Data.Interfaces;

namespace TestDotnetMsSql.Test.Business.EmployeeServiceSpec
{
    public abstract class UsingEmployeeServiceSpec : SpecFor<EmployeeService>
    {
        protected IEmployeeRepository _employeeRepository;

        public override void Context()
        {
            _employeeRepository = Substitute.For<IEmployeeRepository>();
            subject = new EmployeeService(_employeeRepository);

        }

    }
}
