namespace TodoApp.Core;

public class TodoItem
{
    public string Text { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public bool Done { get; set; }

    public TodoItem(string text)
    {
        Text = text;
    }
}
