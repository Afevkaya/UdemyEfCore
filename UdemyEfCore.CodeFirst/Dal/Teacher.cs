namespace UdemyEfCore.CodeFirst.Dal;

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    // Navigation Property
    public List<Student> Students { get; set; }
}