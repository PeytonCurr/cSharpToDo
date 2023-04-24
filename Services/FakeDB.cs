namespace cSharpToDo.Repositories;

public class FakeDB
{
  public List<ToDo> ToDos;

  public FakeDB()
  {
    ToDos = new List<ToDo>();
    ToDos.Add(new ToDo(1, "Laundry", false));
    ToDos.Add(new ToDo(2, "Cook Ground Beef", false));
    ToDos.Add(new ToDo(3, "Clean Litter Box", false));
  }
}