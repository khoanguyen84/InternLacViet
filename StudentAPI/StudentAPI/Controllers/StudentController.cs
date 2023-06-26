using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Contexts;
using StudentAPI.Entities;
using StudentAPI.Models.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private StudentContext _studentContext;
        public StudentController()
        {
            _studentContext = new StudentContext();
        }
        // GET: api/<StudentController>
        [HttpGet]
        public List<StudentList> Get()
        {
            return _studentContext.Students.Include(s => s.Grade).
            Select(s => new StudentList()
            {
                StudentId = s.StudentId,
                FullName = s.FullName,
                Email = s.Email,
                Grade = s.Grade
            }).ToList();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
