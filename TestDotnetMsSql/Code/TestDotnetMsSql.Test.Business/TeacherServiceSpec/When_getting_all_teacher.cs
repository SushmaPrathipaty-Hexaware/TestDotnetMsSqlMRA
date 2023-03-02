using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using TestDotnetMsSql.Entities.Entities;

namespace TestDotnetMsSql.Test.Business.TeacherServiceSpec
{
    public class When_getting_all_teacher : UsingTeacherServiceSpec
    {
        private IEnumerable<Teacher> _result;

        private IEnumerable<Teacher> _all_teacher;
        private Teacher _teacher;

        public override void Context()
        {
            base.Context();

            _teacher = new Teacher{
                name = "name"
            };

            _all_teacher = new List<Teacher> { _teacher};
            _teacherRepository.GetAll().Returns(_all_teacher);
        }
        public override void Because()
        {
            _result = subject.GetAll();
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _teacherRepository.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<List<Teacher>>();

            List<Teacher> resultList = _result as List<Teacher>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_teacher);
        }
    }
}
