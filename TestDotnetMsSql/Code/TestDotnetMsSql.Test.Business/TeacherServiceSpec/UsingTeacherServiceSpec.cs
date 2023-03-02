using NSubstitute;
using TestDotnetMsSql.Test.Framework;
using TestDotnetMsSql.Business.Services;
using TestDotnetMsSql.Data.Interfaces;

namespace TestDotnetMsSql.Test.Business.TeacherServiceSpec
{
    public abstract class UsingTeacherServiceSpec : SpecFor<TeacherService>
    {
        protected ITeacherRepository _teacherRepository;

        public override void Context()
        {
            _teacherRepository = Substitute.For<ITeacherRepository>();
            subject = new TeacherService(_teacherRepository);

        }

    }
}
