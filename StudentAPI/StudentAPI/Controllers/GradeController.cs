using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Contexts;
using StudentAPI.Models.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private StudentContext _studentContext;
        public GradeController()
        {
            _studentContext = new StudentContext();
        }
        // GET: api/<GradeController>
        [HttpGet]
        public List<GradeList> Get()
        {
            return _studentContext.Grades.Include(g => g.Students)
                        .Select(g => new GradeList()
                        {
                            GradeId = g.GradeId,
                            GradeName = g.GradeName,
                            Completed = g.Completed,
                            Students = g.Students
                        }).ToList();
        }

        // GET api/<GradeController>/5
        [HttpGet("{id}")]
        public GradeList? Get(int id)
        {
            return _studentContext.Grades.Include(g => g.Students)
                       .Where(g => g.GradeId == id)
                       .Select(g => new GradeList()
                       {
                           GradeId = g.GradeId,
                           GradeName = g.GradeName,
                           Completed = g.Completed,
                           Students = g.Students
                       }).FirstOrDefault();
        }

        // POST api/<GradeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GradeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GradeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
