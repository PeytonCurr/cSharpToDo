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

  [HttpGet("{ToDoId}")]
  public ActionResult<ToDo> GetOne(int ToDoId)
  {
    try
    {
      ToDo toDo = _toDosService.GetOne(ToDoId);
      return Ok(toDo);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}