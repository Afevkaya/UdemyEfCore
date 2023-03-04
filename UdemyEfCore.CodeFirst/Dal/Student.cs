namespace UdemyEfCore.CodeFirst.Dal;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int  Age { get; set; }
    // Navigation Property
    public List<Teacher> Teachers { get; set; }
}