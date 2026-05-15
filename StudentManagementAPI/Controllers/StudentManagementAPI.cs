using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagementAPI.Models;
using System.Collections.Immutable;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Linq;
namespace StudentManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase


    {


        private static List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Hassan", Age = 22 },
            new Student { Id = 2, Name = "Ali", Age = 21 }

        };

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(students);
        }


        [HttpGet("{id}")]
        public IActionResult GetStudentbyId(int id)
        {
            // 1. We ask the list: "Find the FIRST student WHERE the Id matches the one from the URL"
            var student = students.FirstOrDefault(x => x.Id == id);

            // 2. Check if we actually found someone
            if (student == null)
            {
                return NotFound("Student not found!");
            }

            // 3. Return that specific student
            return Ok(student);
        }

        //[HttpPost]
        //public IActionResult AddStudent(CreateStudentDto dto)
        //{
        //    var student = new Student
        //    {
        //        Id = students.Count + 1, // This is a simple way to generate a new ID. In a real application, you'd use a database.
        //        Name = dto.Name,
        //        Age = dto.Age
        //    };
        //    students.Add(student);
        //    return Ok(student);
        //}
        //so will the user enter the name and age on frontend then it all goes to the dto object inside parameter and then is used
        //inside the : var student = new Student

        //{

        //    Id = students.Count + 1, // This is a simple way to generate a new ID. In a real application, you'd use a database.

        //    Name = dto.Name,

        //    Age = dto.Age

        //};

        [HttpPost]
        public IActionResult AddStudent(CreateStudentDto dto)
        {
            var student = new Student
            {
                Id = students.Count + 1,
                Name = dto.Name,
                Age = dto.Age
            };

            students.Add(student);

            return CreatedAtAction(
                nameof(GetStudentbyId),
                new { id = student.Id },
                student
            );
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, UpdateStudentDto dto)
        {
            var student = students.FirstOrDefault(x => x.Id == id);

            if (student == null)
                return NotFound("Student not found");

            student.Name = dto.name;
            student.Age = dto.age;

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);
            if (student == null)
                return NotFound("Student not found");
            students.Remove(student);
            return Ok("Student deleted successfully");
        }
    }
}
