namespace cSharpToDo.Repositories;

public class ToDosRepository
{
  private readonly FakeDB _db;

  public ToDosRepository(FakeDB db)
  {
    _db = db;
  }

  internal List<ToDo> Get()
  {
    return _db.ToDos;
  }

  internal ToDo GetOne(int ToDoId)
  {
    ToDo toDo = _db.ToDos.Find(t => t.Id == ToDoId);
    return toDo;
  }
}