namespace School;

public class SchoolMain
{
    public static void Main(string[] args)
    {
        SchoolContext database = new SchoolContext();
        database.Database.EnsureCreated();

        StartProgram:

        Console.WriteLine("Menu:");
        Console.WriteLine("1 - Visualizar dados");
        Console.WriteLine("2 - Inserir dados");

        int option = int.Parse(Console.ReadLine()!);

        switch(option) {
            case 1:
                SelectStudents(database);
                goto StartProgram;
            case 2:
                InsertStudents(database);
                goto StartProgram;
        }
    }

    public static void SelectStudents( SchoolContext database)
    {
        Console.Clear();
        foreach(Student student in database.Students)
        {
            Console.WriteLine($"{student.Name} - {student.Course}");
        }
    }

     public static void InsertStudents( SchoolContext database)
    {
        Console.Clear();
        Console.WriteLine("Digite o nome da pessoa estudante");
        string name = Console.ReadLine()!;

        Console.WriteLine("Digite o curso");
        string course = Console.ReadLine()!;

        Student newStudent = new Student
        {
            Name = name,
            Course = course
        };
        database.Students.Add(newStudent);
        database.SaveChanges();
    }
}