using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class StudentController : ControllerBase
{
    private readonly IStudentService _service;

    public StudentController(IStudentService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var students = await _service.GetAll();
        return Ok(students);
    }

    [HttpPost]
    public async Task<IActionResult> Add(Student student)
    {
        var result = await _service.Add(student);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update(Student student)
    {
        var result = await _service.Update(student);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.Delete(id);
        return result ? Ok() : NotFound();
    }
}