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
}
