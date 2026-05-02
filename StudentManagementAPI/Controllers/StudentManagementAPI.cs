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

       private static  List<string> studetns  =new List<string>(){"Student1","Student2","Student3"};

        [HttpPost]
        public IActionResult AddStudent([FromBody] string name)
        {
            if(studetns.Count >= 5)
            {
                return BadRequest("Cannot add more than 5 students.");
            }
            studetns.Add(name);
            return Ok("studetn added sucessfully>>>");
        }

    }
}
