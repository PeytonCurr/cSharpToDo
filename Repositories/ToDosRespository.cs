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
}