namespace StudentRegister;

public delegate void MarkHandler(string msg);

public class Student : Person
{
    private int _mark;

    public event MarkHandler? OnMarkAdded;

    public CourseCode Course { get; set; }

    public int Mark
    {
        get => _mark;
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine($"[Validation Rejected] Mark {value} is invalid for student '{name}'. Must be between 0 and 100.");
                return;
            }

            _mark = value;
            OnMarkAdded?.Invoke($"[Event: OnMarkAdded] Valid mark of {value} was recorded for {name} (ID: {id}).");
        }
    }

    public Student(string name, int id, CourseCode course)
        : base(name, id)
    {
        Course = course;
    }

    public override void Describe()
    {
        Console.WriteLine($"Student: {name,-12} | ID: {id,-6} | Course: {Course,-22} | Mark: {Mark}/100");
    }
}
