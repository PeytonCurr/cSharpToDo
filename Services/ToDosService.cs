namespace cSharpToDo.Services;

public class ToDosService
{
  private readonly ToDosRepository _repo;

  public ToDosService(ToDosRepository repo)
  {
    _repo = repo;
  }

  internal List<ToDo> Get()
  {
    List<ToDo> toDos = _repo.Get();
    return toDos;
  }
}