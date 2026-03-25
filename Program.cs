using System.Diagnostics;
using System.Xml.Linq;

namespace Eraasoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students: ");
            int.TryParse(Console.ReadLine(), out int NumOfStds);

            List<Student> students = new List<Student>();
            //List<string> StdNamelist = new List<string>();
            //List<int> StdGradelist = new List<int>();
            //int StdGrade = 0;


            for (int i = 0; i < NumOfStds; i++)
            {
                //Console.WriteLine("Enter Student Names: ");
                //string StdName = Console.ReadLine();
                //StdNamelist.Add(StdName);

                //Console.WriteLine("Enter Student Grade: ");
                //StdGrade = Convert.ToInt32(Console.ReadLine());
                //StdGradelist.Add(StdGrade);

                Student student = new Student();
                Console.WriteLine("Enter Student Names: ");
                student.Name = Console.ReadLine();

                Console.WriteLine("Enter Student Grade: ");
                student.Grade = Convert.ToInt32(Console.ReadLine());

                students.Add(student);
            }

            foreach (Student Std in students)
            {
                string classification;

                if (Std.Grade >= 90)
                    classification = "Excellent";
                else if (Std.Grade >= 75)
                    classification = "Very Good";
                else if (Std.Grade >= 60)
                    classification = "Good";
                else if (Std.Grade >= 50)
                    classification = "Pass";
                else
                    classification = "Fail";

                Console.WriteLine("Student Name: " + Std.Name);
                Console.WriteLine("Grade: " + Std.Grade);
                Console.WriteLine("Grade Classification: " + classification);
            }

           
            do
            {
                Console.WriteLine("choose an action: ");
                Console.WriteLine("1.Show all students\n 2.Show average grade\n 3.Show highest grade\n 4.Show failed students\n 5.Exit");
                 int.TryParse(Console.ReadLine(), out int num);

                switch (num)
                {
                    case 1:
                        foreach (Student s in students)
                        {
                            Console.WriteLine(s.Name);
                        }
                        break;
                    case 2:
                        double sum = 0;
                        foreach (Student s in students)
                        {
                            sum += s.Grade;
                        }

                        double average = sum / students.Count;

                        Console.WriteLine("Average = " + average);
                        break;
                    case 3:
                        int max = students[0].Grade; 

                        foreach (Student s in students)
                        {
                            if (s.Grade > max)
                            {
                                max = s.Grade;
                            }
                        }

                        Console.WriteLine("Highest Grade = " + max);
                        break;
                    case 5:
                        return;
                        break;

                }
            }
            while (true);



            //for (int i =0; i<= StdNamelist.Count; i++)
            //{
            //    string StdName = StdNamelist[i];
            //    int SrdGrade = StdGradelist[i];
            //    string classification;

            //if (StdGrade >= 90)
            //    classification = "Excellent";
            //else if (StdGrade >= 75)
            //    classification = "Very Good";
            //else if (StdGrade >= 60)
            //    classification = "Good";
            //else if (StdGrade >= 50)
            //    classification = "Pass";
            //else
            //    classification = "Fail";

            //    Console.WriteLine($"Student Name: {StdName}");
            //    Console.WriteLine($"Grade: {StdGrade}" );
            //    Console.WriteLine($"Grade Classification: {classification}");
            //}

            //if (StdGrade >= 90)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else if (StdGrade >= 75)
            //{
            //    Console.WriteLine("Very Good");
            //}
            //else if (StdGrade >= 60)
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (StdGrade >= 50)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else if (StdGrade < 50)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else
            //{
            //    Console.WriteLine("Not a valid grade");
            //}

            //foreach (string name in StdNamelist)
            //{
            //    Console.WriteLine(name);
            //}
            //foreach (int grade in StdGradelist)
            //{
            //    Console.WriteLine(grade);
            //}
        }

    }
}
