namespace cSharpToDo.Controllers;

[ApiController]
[Route("api/ToDos")]
public class ToDosController : ControllerBase
{
  private readonly ToDosService _toDosService;

  public ToDosController(ToDosService toDosService)
  {
    _toDosService = toDosService;
  }

  [HttpGet]
  public ActionResult<List<ToDo>> Get()
  {
    try
    {
      List<ToDo> toDos = _toDosService.Get();
      return Ok(toDos);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}