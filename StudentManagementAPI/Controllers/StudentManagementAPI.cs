using Microsoft.AspNetCore.Mvc;
namespace StudentManagementAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetallStudents()
        {
            return Ok("All Students data>>>");
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentbyId(int id)
        {
            return Ok($"Student data for ID: {id}>>>");
        }
    }
}
