namespace Domain.Todo;

using Domain.User;

public class Todo
{
    public int Id { get; set; }
    public string Title { get; }
    public bool IsCompleted { get;}
    public User Owner { get; }
}