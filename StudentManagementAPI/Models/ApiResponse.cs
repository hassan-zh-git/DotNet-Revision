using StudentManagementAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentManagementAPI.Models
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
    }
}



//We'll properly learn Generics later.

//For now understand:

//ApiResponse<Student>
//ApiResponse<List<Student>>
//ApiResponse<string>

//Same class works for any data type.