using System;
namespace CSharp
{
    public class PatternMatchingDemo
    {
        public PatternMatchingDemo()
        {

        }

        public void Demo()
        {
            Records rec = new Records();
            rec.DisplayRecords(new Student() { Name = "Louis", School = "LFHSS", Grade = "A" });
            rec.DisplayRecords(new Teacher() { Name = "Ulaganathan", School = "Govt. Hr. Sec. School", NumberOfStudents = "3" });
        }

        //C# 7.0 Pattern matching feature using "is" pattern expression
        public static void Main(string[] args)
        {
            PatternMatchingDemo patternMatching = new PatternMatchingDemo();
            patternMatching.Demo();
        }
    }

    public class Student
    {
        public string Name;
        public string School;
        public string Grade;
    }
    public class Teacher
    {
        public string Name;
        public string School;
        public string NumberOfStudents;
    }
    public class Records
    {
        public void DisplayRecords(object record)
        {

            //C# <7.0 Needs type cast of object to individual type to use
            //Console.WriteLine($"Name : {record.Name}");

            //C# 7.0  : If conditional block
            if(record is Student student)
            {
                Console.WriteLine("****Student****");
                Console.WriteLine($"Name : {student.Name}");
                Console.WriteLine($"Name : {student.School}");
                Console.WriteLine($"Name : {student.Grade}");
                Console.WriteLine("__________________________");
            }
            if(record is Teacher teacher)
            {
                Console.WriteLine("****Teacher****");
                Console.WriteLine($"Name : {teacher.Name}");
                Console.WriteLine($"Name : {teacher.School}");
                Console.WriteLine($"Name : {teacher.NumberOfStudents}");
                Console.WriteLine("__________________________");
            }

            //C# 7.0  : Switch conditional block

            Console.WriteLine("****Switch output****");

            switch (record)
            {
                case Student student1:
                    {
                        Console.WriteLine("****Student****");
                        Console.WriteLine($"Name : {student1.Name}");
                        Console.WriteLine($"Name : {student1.School}");
                        Console.WriteLine($"Name : {student1.Grade}");
                        Console.WriteLine("__________________________");
                        break;
                    }
                case Teacher teacher1:
                    {
                        Console.WriteLine("****Teacher****");
                        Console.WriteLine($"Name : {teacher1.Name}");
                        Console.WriteLine($"Name : {teacher1.School}");
                        Console.WriteLine($"Name : {teacher1.NumberOfStudents}");
                        Console.WriteLine("__________________________");
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
