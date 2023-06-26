using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Entities
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [Required]
        [Column(TypeName="NVARCHAR(50)")]
        [StringLength(50)]
        public string GradeName { get; set; }
        public bool Completed { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
