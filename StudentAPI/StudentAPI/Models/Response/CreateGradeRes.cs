using StudentAPI.Entities;

namespace StudentAPI.Models.Response
{
    public class CreateGradeRes : BaseRes<Grade>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
