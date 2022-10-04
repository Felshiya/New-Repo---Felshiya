using System.Collections.Generic;
using MongoDB.Business.Interfaces;
using MongoDB.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MongoDB.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentService _StudentService;
        public StudentController(IStudentService StudentService)
        {
            _StudentService = StudentService;
        }

        // GET: api/Student
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return Ok(_StudentService.GetAll());
        }

        [HttpPost]
        public ActionResult<Student> Save(Student Student)
        {
            return Ok(_StudentService.Save(Student));

        }

        [HttpPut("{id}")]
        public ActionResult<Student> Update([FromRoute] string id, Student Student)
        {
            return Ok(_StudentService.Update(id, Student));

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete([FromRoute] string id)
        {
            return Ok(_StudentService.Delete(id));

        }


    }
}
