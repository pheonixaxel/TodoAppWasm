using System.Text.Json;
using Domain.Todo;
using Domain.User;

namespace FileData;

public class FileContext
{
    private const string filePath = "data.json";
    private DataContainer? dataContainer;

    public ICollection<Todo> Todos
    {
        get
        {
            LoadData();
            return dataContainer!.Todos;
        }
    }

    private void LoadData()
    {
        if (dataContainer != null)
            return;

        if (!File.Exists(filePath))
        {
            dataContainer = new()
            {
                Todos = new List<Todo>(),
                Users = new List<User>()
            };
            return;
        }
        
        string content = File.ReadAllText(filePath);
        dataContainer = JsonSerializer.Deserialize<DataContainer>(content);
        {
            
        }
    }

    public ICollection<User> Users
    {
        get
        {
            LoadData();
            return dataContainer!.Users;
        }
    }
    
    public void SaveChanges()
    {
        string content = JsonSerializer.Serialize(dataContainer);
        File.WriteAllText(filePath, content);
        dataContainer = null;
    }
}