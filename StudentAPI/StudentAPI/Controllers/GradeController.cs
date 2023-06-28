using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Contexts;
using StudentAPI.Entities;
using StudentAPI.Models.Request;
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
            //Lambda Expression
            //return _studentContext.Grades.Include(g => g.Students)
            //            .Select(g => new GradeList()
            //            {
            //                GradeId = g.GradeId,
            //                GradeName = g.GradeName,
            //                Completed = g.Completed,
            //                Students = g.Students
            //            }).ToList();

            //LinQ
            //return (from g in _studentContext.Grades
            //        select new GradeList()
            //        {
            //            GradeId = g.GradeId,
            //            GradeName = g.GradeName,
            //            Completed = g.Completed,
            //            Students = (from s in _studentContext.Students where s.GradeId == g.GradeId select s).ToList(),
            //        }).ToList();

            return (from g in _studentContext.Grades 
                    join s in _studentContext.Grades
                    on g.GradeId equals s.GradeId
                    select new GradeList()
                    {
                        GradeId = g.GradeId,
                        GradeName = g.GradeName,
                        Completed = g.Completed,
                        Students = s.Students,
                    }).ToList();
        }

        // GET api/<GradeController>/5
        [HttpGet("{id}")]
        public GradeList? Get(int id)
        {
            //Lambda Expression

            //return _studentContext.Grades.Include(g => g.Students)
            //           .Where(g => g.GradeId == id)
            //           .Select(g => new GradeList()
            //           {
            //               GradeId = g.GradeId,
            //               GradeName = g.GradeName,
            //               Completed = g.Completed,
            //               Students = g.Students
            //           }).FirstOrDefault();


            //LinQ
            return (from g in _studentContext.Grades
                    join s in _studentContext.Grades
                    on g.GradeId equals s.GradeId
                    where g.GradeId == id
                    select new GradeList()
                    {
                        GradeId = g.GradeId,
                        GradeName = g.GradeName,
                        Completed = g.Completed,
                        Students = s.Students,
                    }).FirstOrDefault();
        }

        // POST api/<GradeController>
        [HttpPost]
        public CreateGradeRes Post([FromBody] CreateGradeReq request)
        {
            try
            {
                Grade newGrade = new Grade()
                {
                    GradeName = request.GradeName,
                    Completed = request.Completed
                };
                _studentContext.Add(newGrade);
                int rowsEffect =  _studentContext.SaveChanges();
                return new CreateGradeRes()
                {
                    Success = true,
                    Message = $"Grade: {newGrade.GradeName} created success",
                    Payload = newGrade
                };
            }
            catch (Exception e)
            {
                return new CreateGradeRes()
                {
                    Success = false,
                    //Message = e.Message,
                    Message = "Something went wrong, please contact administrator"
                };
            }
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
