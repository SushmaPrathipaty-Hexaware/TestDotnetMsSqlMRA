using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using TestDotnetMsSql.Entities.Entities;


namespace TestDotnetMsSql.Test.Business.TeacherServiceSpec
{
    public class When_updating_teacher : UsingTeacherServiceSpec
    {
        private Teacher _result;
        private Teacher _teacher;

        public override void Context()
        {
            base.Context();

            _teacher = new Teacher
            {
                name = "name"
            };

            _teacherRepository.Update( _teacher).Returns(_teacher);
            
        }
        public override void Because()
        {
            _result = subject.Update( _teacher);
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _teacherRepository.Received(1).Update( _teacher);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<Teacher>();

            _result.ShouldBe(_teacher);
        }
    }
}
