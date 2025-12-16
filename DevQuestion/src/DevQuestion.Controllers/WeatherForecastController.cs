using Microsoft.AspNetCore.Mvc;

namespace DevQuestion.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
    [HttpGet]
    public void Test()
    {

    }
}
