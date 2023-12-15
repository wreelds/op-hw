using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Number { get; set; }
    public string Department { get; set; }
}

public class Program
{
    public static void Main()
    {
        var students = new List<Student>();

        for (int i = 0; i < 10; i++)
        {
            var student = new Student();

            Console.WriteLine($"Student {i + 1}:");

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Surname: ");
            student.Surname = Console.ReadLine();

            Console.Write("Enter Number: ");
            student.Number = Console.ReadLine();

            Console.Write("Enter Department: ");
            student.Department = Console.ReadLine();

            students.Add(student);
        }

        Console.WriteLine("\nStudents Details:");

        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Number: {student.Number}, Department: {student.Department}");
        }
    }
}