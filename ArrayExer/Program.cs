using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] CourseId = { 6211, 6210, 6209, 6212, 4562, 4678, 2613, 5672, 4325, 9437 };
            string[] Names = { "class1", "class2", "class3", "class4", "class5", "class6", "class7", "class8", "class9", "class10" };
            
            //CourseId Array
            Console.WriteLine("Course Id's are: ");
            foreach (int i in CourseId)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Array Length
            Console.WriteLine("Length of Course Id Array: ");
            Console.WriteLine(CourseId.Length);
            Console.WriteLine();

            //Copy Array
            int[] CopyCourse = new int[10];
            Array.Copy(CourseId, CopyCourse, 10);
            Console.WriteLine("Copy of Course ID Array: ");

            foreach (int i in CopyCourse)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Array Type



            //CourseName Array
            Console.WriteLine("Course Names are: ");
            foreach (string i in Names)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Array length
            Console.WriteLine("Length of Course Names Array: ");
            Console.WriteLine(Names.Length);
            Console.WriteLine();

            //Copy Array
            string[] CopyName = new string[10];
            Array.Copy(Names, CopyName, 10);
            Console.WriteLine("Copy of Course Names Array: ");

            foreach (string i in CopyName)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();





            Console.ReadLine();



        }
    }
}
