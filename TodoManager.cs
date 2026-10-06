namespace TodoApp.Core;

public class TodoManager
{
    private readonly List<TodoItem> _items = new();

    public bool AddTask(string text)
    {
        var item = new TodoItem(text);
        _items.Add(item);
        return true;
    }

    public void Remove(int index) => _items.RemoveAt(index);

    public void MarkDone(int index) => _items[index].Done = true;
}
