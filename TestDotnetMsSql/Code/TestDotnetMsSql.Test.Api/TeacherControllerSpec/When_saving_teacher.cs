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
    public class When_saving_teacher : UsingTeacherControllerSpec
    {
        private ActionResult<Teacher> _result;

        private Teacher _teacher;

        public override void Context()
        {
            base.Context();

            _teacher = new Teacher
            {
                name = "name"
            };

            _teacherService.Save(_teacher).Returns(_teacher);
        }
        public override void Because()
        {
            _result = subject.Save(_teacher);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _teacherService.Received(1).Save(_teacher);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<Teacher>();

            var resultList = (Teacher)resultListObject;

            resultList.ShouldBe(_teacher);
        }
    }
}
