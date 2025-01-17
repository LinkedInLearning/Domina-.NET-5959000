using myapp;
using System.Text.Json;

Console.WriteLine("Hola, mundo.");

var processes = new List<MyProcess>
{
    new(1_000_000),
    new(2_000_000),
    new(3_350_432),
    new(4),
    new(5)
};

var json = JsonSerializer.Serialize(processes);

processes.ForEach(p => Console.WriteLine(p.Process()));


Console.WriteLine();