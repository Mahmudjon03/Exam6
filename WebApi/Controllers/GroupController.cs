using Domain.Models;
using Infracstructure.Servises;
using Microsoft.AspNetCore.Mvc;
namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]

public class GroupController : ControllerBase
{
    private readonly StudentServise _studentService;
    private readonly GroupServise _groupService;
    public GroupController() => _groupService = new GroupServise();

    [HttpGet("GetGroup")]
    public List<Group> GetStudent() => _groupService.GetGroup();

    [HttpPost("AddGrop")]
    public void AddGroup(Group s)   =>  _groupService.Add(s);
    
    [HttpPut("UdateGroup")]
    public void UdateGroup(Group s) => _groupService.UpdateGroup(s);
    
    [HttpDelete("DeleteGroup")]
    public void DeleteGroup(int a) =>  _groupService.DeleteGroup(a);
    
    [HttpGet("GetGroupById")]
    public Group GetGroupById(int id) => _groupService.GEtById(id);

    [HttpGet("StudentGroupName")]
    public List<StudentGroupName> GetStudentGroupNames() => _groupService.GetStudentGroupName();


}



