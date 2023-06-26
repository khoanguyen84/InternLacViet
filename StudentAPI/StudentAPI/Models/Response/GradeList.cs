using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentAPI.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models.Response
{
    public class GradeList
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public bool Completed { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
