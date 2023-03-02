using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using TestDotnetMsSql.Entities.Entities;

namespace TestDotnetMsSql.Test.Api.TeacherControllerSpec
{
    public class When_getting_all_teacher : UsingTeacherControllerSpec
    {
        private ActionResult<IEnumerable<Teacher>> _result;

        private IEnumerable<Teacher> _all_teacher;
        private Teacher _teacher;

        public override void Context()
        {
            base.Context();

            _teacher = new Teacher{
                name = "name"
            };

            _all_teacher = new List<Teacher> { _teacher};
            _teacherService.GetAll().Returns(_all_teacher);
        }
        public override void Because()
        {
            _result = subject.Get();
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _teacherService.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<List<Teacher>>();

            List<Teacher> resultList = resultListObject as List<Teacher>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_teacher);
        }
    }
}
