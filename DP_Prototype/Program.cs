using DesignPatterns.Prototype.SimplePrototype;

Teacher teacher = new Teacher("Jean-Charles", "Creational Design Patterns");
Teacher teacherClone = (Teacher)teacher.Clone();
Console.WriteLine($"Teacher was cloned: {teacherClone.Name} who teaches {teacherClone.Course}");

Student student = new Student("James", teacherClone);
Student studentClone = (Student)student.Clone();
Console.WriteLine($"Student was cloned: {studentClone.Name} who is enrolled in {studentClone.Teacher.Name}'s course");

teacherClone.Name = "John";
Console.WriteLine($"Student was cloned: {studentClone.Name} who is enrolled in {studentClone.Teacher.Name}'s course");