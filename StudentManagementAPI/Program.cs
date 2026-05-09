using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;
using System.Numerics;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();






//?? Complete Flow Step-by-Step
//1?? Client Request

//Client sends data:

//{
//    "name":"Hassan",
//   "age":22
//}

//This comes from:

//React frontend
//Mobile app
//Swagger
//Postman
//Browser

//2?? DTO Receives Data

//ASP.NET Core automatically converts JSON into DTO object:

//CreateStudentDto dto

//Internally becomes:

//dto.Name = "Hassan"
//dto.Age = 22

//This process is:

//Model Binding
//3?? Validation Runs

//ASP.NET checks DTO rules:

//[Required]
//[Range(18, 40)]

//Checks:

//? Is name empty?
//? Is age valid?

//4?? Controller Executes

//If validation passes:

//Controller method runs:

//public IActionResult AddStudent(CreateStudentDto dto)
//5?? Entity Created

//Now we convert DTO ? Entity:

//var student = new Student
//{
//    Id = students.Count + 1,
//    Name = dto.Name,
//    Age = dto.Age
//};

//Why?

//Because DTO is request model.

//Entity represents actual stored data.

//6?? Data Stored

//Currently:

//students.Add(student);

//stores in List.

//Later in Phase 5:

//SQL Database
//MongoDB
//7?? Response Returned

//Backend sends response:

//return Ok(student);

//Frontend receives:

//{
//    "id":1,
//   "name":"Hassan",
//   "age":22
//}