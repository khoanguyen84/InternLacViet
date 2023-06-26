using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentAPI.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models.Response
{
    public class StudentList
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Grade Grade { get; set; }
    }
}
