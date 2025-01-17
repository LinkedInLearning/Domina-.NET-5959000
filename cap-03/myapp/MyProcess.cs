using System.Diagnostics;

namespace myapp;

[DebuggerDisplay("{Id} - {Name, nq}")]
public class MyProcess(int id)
{
    public int Id { get; } = id;

    public string Name { get; } = Guid.NewGuid().ToString();

    public int Process()
    {
        return Random.Shared.Next(Id, 1000);
    }
}