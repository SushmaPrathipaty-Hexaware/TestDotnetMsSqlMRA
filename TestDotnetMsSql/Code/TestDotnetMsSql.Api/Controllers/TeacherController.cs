using System.Collections.Generic;
using TestDotnetMsSql.Business.Interfaces;
using TestDotnetMsSql.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace TestDotnetMsSql.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        ITeacherService _TeacherService;
        public TeacherController(ITeacherService TeacherService)
        {
            _TeacherService = TeacherService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Teacher>> Get()
        {
            return Ok(_TeacherService.GetAll());
        }

        [HttpPost]
        public ActionResult<Teacher> Save(Teacher Teacher)
        {
            return Ok(_TeacherService.Save(Teacher));

        }

        [HttpPut]
        public ActionResult<Teacher> Update( Teacher Teacher)
        {
            return Ok(_TeacherService.Update(Teacher));

        }

        [HttpDelete]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(_TeacherService.Delete(id));

        }
        [HttpGet("{id:int}")]
        public ActionResult<Teacher> GetById(int id)
        {
            return Ok(_TeacherService.GetById(id));
        }

    }
}
