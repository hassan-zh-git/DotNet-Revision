using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models
{
    public class CreateStudentDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(17, 40)]
        public int Age { get; set; }
    }
}
//after putting [Required] and [StringLength(50)] on the Name property, if the user tries to create a student without providing a name or with a name longer than 50 characters, the API will return a validation error. Similarly, the [Range(17, 40)] attribute on the Age property ensures that the age provided is between 17 and 40. If the user tries to create a student     
//with an age outside of this range, the API will also return a validation error. This helps to ensure that the data being entered into the system is valid and meets the specified criteria.
//if(dto.Name == "")   dont need to write this in post method because we have already put [Required] on the Name property, so if the user tries to create a student without providing a name, the API will automatically return a validation error without needing to check for an empty string in the code.

//Never trust client/frontend.

//Always validate backend.