using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercAlunosCurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int totCourses = 3;
            HashSet<int> hsStudents = new HashSet<int>();
            for (int i = 0; i < totCourses; i++)
            {
                char courseLetter = 'A';
                switch (i)
                {
                    case 1 :
                        {
                            courseLetter = 'B';
                            break;
                        }
                    case 2 :
                        {
                            courseLetter = 'C';
                            break;
                        }
                }

                Console.Write("How many students for course " + courseLetter + "? ");
                int students = int.Parse(Console.ReadLine());
                for (int j = 0; j < students; j++)
                {                    
                    hsStudents.Add(int.Parse(Console.ReadLine()));
                }
            }

            Console.WriteLine("Total students: " + hsStudents.Count);
        }
    }
}
