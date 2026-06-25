using System;

class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Grade { get; set; }

    public Student(string name,
                   int id,
                   string grade)
    {
        Name = name;
        Id = id;
        Grade = grade;
    }
}

class StudentView
{
    public void DisplayStudentDetails(
        Student student)
    {
        Console.WriteLine(
            "ID    : " + student.Id);

        Console.WriteLine(
            "Name  : " + student.Name);

        Console.WriteLine(
            "Grade : " + student.Grade);
    }
}

class StudentController
{
    private Student model;
    private StudentView view;

    public StudentController(
        Student model,
        StudentView view)
    {
        this.model = model;
        this.view = view;
    }

    public void UpdateGrade(
        string grade)
    {
        model.Grade = grade;
    }

    public void UpdateView()
    {
        view.DisplayStudentDetails(
            model);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(
            "========== MVC PATTERN ==========\n");

        Student student =
            new Student(
                "Shreyansh",
                101,
                "A");

        StudentView view =
            new StudentView();

        StudentController controller =
            new StudentController(
                student,
                view);

        Console.WriteLine(
            "Student Details:\n");

        controller.UpdateView();

        Console.WriteLine(
            "\nUpdating Grade...\n");

        controller.UpdateGrade("A+");

        Console.WriteLine(
            "Updated Student Details:\n");

        controller.UpdateView();

        Console.WriteLine(
            "\n=================================");
    }
}