using Domain.Todo;
using Domain.User;

namespace FileData;

public class DataContainer
{
    public ICollection<User> Users { get; set; }
    public ICollection<Todo> Todos { get; set; }
}