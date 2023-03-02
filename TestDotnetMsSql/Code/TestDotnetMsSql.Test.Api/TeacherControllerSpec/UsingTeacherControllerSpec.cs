using NSubstitute;
using TestDotnetMsSql.Test.Framework;
using TestDotnetMsSql.Api.Controllers;
using TestDotnetMsSql.Business.Interfaces;


namespace TestDotnetMsSql.Test.Api.TeacherControllerSpec
{
    public abstract class UsingTeacherControllerSpec : SpecFor<TeacherController>
    {
        protected ITeacherService _teacherService;

        public override void Context()
        {
            _teacherService = Substitute.For<ITeacherService>();
            subject = new TeacherController(_teacherService);

        }

    }
}
