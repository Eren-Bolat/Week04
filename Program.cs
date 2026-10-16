namespace StudentRegister;

public class Program
{
    public static void HandleMarkAdded(string msg)
    {
        Console.WriteLine($"   --> Notification received: {msg}");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("==========================================================");
        Console.WriteLine("        CPE 317 - Visual Programming - Week 03 Lab        ");
        Console.WriteLine("                 Student Register Console                 ");
        Console.WriteLine("==========================================================\n");

        CourseCode course1 = new CourseCode("CPE 317", 4);
        CourseCode course2 = new CourseCode("CPE 315", 3);

        Console.WriteLine("[Step 1] Creating 2 Student objects...");
        Student student1 = new Student("Alice Smith", 2023001, course1);
        Student student2 = new Student("Bob Johnson", 2023002, course2);
        Console.WriteLine("   Students created successfully.\n");

        Console.WriteLine("[Step 2] Subscribing to OnMarkAdded event...");
        student1.OnMarkAdded += HandleMarkAdded;
        student2.OnMarkAdded += HandleMarkAdded;
        Console.WriteLine("   Subscribed successfully.\n");

        Console.WriteLine("[Step 3] Adding marks to students...");

        Console.WriteLine("\n-- Adding valid marks (within 0-100 range) --");
        student1.Mark = 88;
        student2.Mark = 94;

        Console.WriteLine("\n-- Testing invalid marks (rejection test: 120 and -10) --");
        student1.Mark = 120;
        student2.Mark = -10;

        Console.WriteLine("\n[Step 4] Calling Describe() on students:");
        Console.WriteLine("--------------------------------------------------------------------------");
        student1.Describe();
        student2.Describe();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("Lab demonstration completed successfully.");
    }
}
