using Microsoft.AspNetCore.Mvc;
namespace proyecto_TeamGitPractice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
  [HttpGet]
  public IActionResult GetMembers()
  {
    var members = new[]
    {
"Jhon Eduardo Zabala Garzón",
"Sebastián Villa Castillo ",
"Brayan Alexis Arango Orrego",
"David Morales Vargas ",
"Laura Posada Taborda"
};
    return Ok(members);
  }

}