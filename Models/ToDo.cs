namespace cSharpToDo.Models;

public class ToDo
{
  public ToDo(int id, string name, bool completed)
  {
    Id = id;
    Name = name;
    Completed = completed;
  }

  public int Id { get; set; }

  public string Name { get; set; }

  public bool Completed { get; set; } = false;

}