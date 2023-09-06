using Domain.Models;
using Infracstructure.Servises;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]

public class StudentController:ControllerBase
    {
    private readonly StudentServise _studentServise;
    public StudentController()
    {
        _studentServise = new StudentServise();
        
    }
    [HttpGet("GetStudent")]
    public List<Student> GetStudent() => _studentServise.GetStudent().ToList();
    [HttpPost("AddStudent")]
    public void AddStudent(Student student) => _studentServise.AddStudent(student);
    [HttpPut("UpdateStudent")]
    public void UpdateStudent(Student f) => _studentServise.UpdateStudent(f);
    [HttpGet("GetStudentById")]
    public Student GEtStudentById(int t) => _studentServise.GEtStudentById(t);
    [HttpDelete("DeleteStudent")]
    public void DeleteStudent(int u) => _studentServise.Delete(u);
    }

