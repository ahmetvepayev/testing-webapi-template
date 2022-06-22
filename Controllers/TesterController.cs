using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TesterController : ControllerBase
{
    private readonly ITesterService _testerService;

    public TesterController(ITesterService testerService)
    {
        _testerService = testerService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_testerService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(_testerService.GetById(id));
    }

    [HttpPost]
    public IActionResult Add(Tester tester)
    {
        _testerService.Add(tester);
        return Ok();
    }

    [HttpPut]
    public IActionResult Update(Tester tester)
    {
        _testerService.Update(tester);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _testerService.Delete(id);
        return Ok();
    }
}
