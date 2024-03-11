namespace DesignPatterns.Prototype.SimplePrototype;

// ConcretePrototype1
public class Teacher : Person
{
    public string Course { get; set; }
    public Teacher(string name, string course) : base(name)
    {
        Course = course;
    }

    public override Person Clone()
    {
        return (Person)MemberwiseClone();
    }
}


