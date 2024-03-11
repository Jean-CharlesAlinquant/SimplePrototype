namespace DesignPatterns.Prototype.SimplePrototype;

// ConcretePrototype2
public class Student : Person
{
    public Teacher Teacher { get; set; }
    public Student(string name, Teacher teacher) : base(name)
    {
        Teacher = teacher;
    }

    public override Person Clone()
    {
        // MemberwiseClone only performs shallow copy
        Student studentClone = (Student)MemberwiseClone();
        // Teacher is a reference type so explicit Deep Copy is required.
        studentClone.Teacher = new Teacher(Teacher.Name, Teacher.Course);
        return studentClone;
    }
}


