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

  internal ToDo GetOne(int ToDoId)
  {
    ToDo toDo = _repo.GetOne(ToDoId);
    if (toDo == null) throw new Exception($"no ToDo at Id {ToDoId}");
    return toDo;
  }

  internal ToDo Create(int toDoData)
  {
    ToDo toDo = _repo.Create(toDoData)
  }
}