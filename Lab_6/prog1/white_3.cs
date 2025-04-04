using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static MainProject.Program;

namespace MainProject
{
    public class White_3
    {
        public struct Student
        {
            private string Surname, Name;
            private int Skipped=0;
            private double[] Marks;
            public string surname => Surname;
            public string name => Name;
            public int skippedd => Skipped;
            public double[] marks => Marks;
            public double AvgMark{
                get
                {
                    if (Marks.Length == 0)
                    {
                        return 0;
                    }
                    double sum = 0;
                    for (int i = 0; i < Marks.Length; i++)
                    {
                        sum += Marks[i];
                    }
                    return sum / ((double)(Marks.Length));
                }
            }
            public void Lesson(int mark)
            {
                if (mark == 0)
                {
                    Skipped++;
                    return;
                }
                double[] t = Marks;
                Marks = new double[t.Length+1];
                for(int i =  t.Length; i < t.Length; i++)
                {
                    Marks[i] = t[i];
                }
                Marks[t.Length] = mark;
            }
            public Student(string _Surname, string _Name, int _Skipped)
            {
                Surname = _Surname;
                Name = _Name;
                Skipped = _Skipped;
                Marks = new double[0];
            }
            public void Print()
            {
                if (surname == null || name == null || marks == null) return;
                Console.Write(surname);
                Console.Write(" ");
                Console.WriteLine(name);
                Console.WriteLine(Skipped);
                Console.Write("Marks : ");
                for(int i = 0;i < marks.Length; i++)
                {
                    Console.Write(marks[i]+" ");
                }
            }
            public static void SortBySkipped(Student[] array)
            {
                if (array == null)
                {
                    return;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j].Skipped > array[i].Skipped)
                        {
                            (array[i], array[j]) = (array[j], array[i]);
                        }
                    }
                }
            }

        };

    }
}
