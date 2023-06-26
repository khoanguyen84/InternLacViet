using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Entities
{
    public class Student
    {
        [Key]
        public int StudentId {get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        [StringLength(50)]
        public string FullName { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        [StringLength(50)]
        public string Email { get; set; }
        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
