namespace DesignPatterns.Prototype.SimplePrototype;

// Prototype
public abstract class Person
{
    public string Name { get; set; }
    protected Person(string name)
    {
        Name = name;
    }
    public abstract Person Clone();
}


