using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//VHP
class Student
{
    private string  name, semester;
    private int enrollmentNo, totalMarks;
    private int[] subjectMarks = new int[5];

    public void GetData()
    {
        Console.Write("Enter Enrollment No : ");
        enrollmentNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Semester: ");
        semester = Console.ReadLine();

        Console.WriteLine("Enter Marks for 5 Subjects:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Subject {i + 1}: ");
            subjectMarks[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void CalculatePercentage()
    {
        for (int i = 0; i < 5; i++)
        {
            totalMarks += subjectMarks[i];
        }

        double percentage = (double)totalMarks / 5;
        Console.WriteLine("\nTotal Marks: " + totalMarks);
        Console.WriteLine("Percentage: " + percentage);
        AssignGrade(percentage);
    }

    public void AssignGrade(double percentage)
    {
        if (percentage >= 90)
            Console.Write("A+");
        else if (percentage >= 80)
            Console.Write("A");
        else if (percentage >= 70)
            Console.Write("B");
        else if (percentage >= 60)
            Console.Write("C");
        else if (percentage >= 50)
            Console.Write("D");
        else
            Console.Write("F");
    }

    public void DisplayMarksheet()
    {
        Console.WriteLine("\nMark Sheet:");
        Console.WriteLine("Enrollment No:"+ enrollmentNo);
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Semester: "+semester);

        Console.WriteLine("\nSubject-wise Marks:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Subject"+ (i + 1)+": "+subjectMarks[i]);
        }

        CalculatePercentage();
    }
}
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();
            student.GetData();
            student.DisplayMarksheet();
            Console.Read();
        }
    }
}
---
using System;

class Program {
  
  static void Main(string[] args) {

    Console.Write("Enter Roll No: ");
    int rollNo = int.Parse(Console.ReadLine());

    Console.Write("Enter Name: ");
    string name = Console.ReadLine();

    Console.Write("Enter Semester: ");
    int sem = int.Parse(Console.ReadLine());

    int[] marks = new int[5];
    for(int i=0; i<5; i++) {
      Console.Write("Enter Marks for Subject " + (i+1) + ": ");
      marks[i] = int.Parse(Console.ReadLine());
    }

    DisplayMarksheet(rollNo, name, sem, marks);

  }

  static void DisplayMarksheet(int rollNo, string name, int sem, int[] marks) {
    
    int total = 0;
    foreach(int mark in marks) 
      total += mark;
    
    double per = total / 5;

    Console.WriteLine("Semester: " + sem);
    Console.WriteLine("Name: " + name);
    Console.WriteLine("Roll No: " + rollNo);
    Console.WriteLine("Total Marks: " + total);
    Console.WriteLine("Percentage: " + per);
      
  }

}