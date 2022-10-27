//Jeremy Lapham
//10-25-22
//Say Hello -Endpoint
//This program says what's up to the user
//Peer review: Reed Goodwin- Functions as ntended with no errors, good UI and nicely coded!

using Microsoft.AspNetCore.Mvc;

namespace LaphamJ_SayHelloEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
  [HttpGet]
  [Route("SayHello/{name}")]

  public string SayHello(string name)
  {
    return $"YOOOOO what's uuuuup {name}";
  }
}
