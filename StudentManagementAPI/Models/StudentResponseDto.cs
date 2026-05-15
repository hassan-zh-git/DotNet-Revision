namespace StudentManagementAPI.Models
{
    public class StudentResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

//Notice Something

//Age removed intentionally.

//Why?

//Because maybe frontend should not see age.

//Response DTO controls output.