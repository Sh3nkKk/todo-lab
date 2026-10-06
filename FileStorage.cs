using System.Text.Json;
namespace TodoApp.Core;

public class FileStorage
{
    private readonly string _path;

    public FileStorage(string path)
    {
        _path = path;
    }

    public void Save(List<TodoItem> items)
    {
        File.WriteAllText(_path, JsonSerializer.Serialize(items));
    }

    public List<TodoItem> Load()
    {
        if (!File.Exists(_path)) return new List<TodoItem>();
        return JsonSerializer.Deserialize<List<TodoItem>>(File.ReadAllText(_path)) ?? new List<TodoItem>();
    }
}
