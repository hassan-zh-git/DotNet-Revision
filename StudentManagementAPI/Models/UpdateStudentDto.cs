using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models
{
    public class UpdateStudentDto
    {

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Range(17, 40)]
        public int age { get; set; }
    }
}
