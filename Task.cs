public class Task
{
    public string Name { get; }
    public int Priority { get; }

    public Task(string name, int priority)
    {
        Name = name;
        Priority = priority;
    }
}