using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Lab_6
{
    public class White_3
    {
        public struct Student
        {
            private string surname, name;
            private int skipped = 0;
            private double[] Marks = new double[0];
            public string Surname => surname;
            public string Name => name;
            public int Skipped { get { return skipped; } }
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
                    skipped++;
                    return;
                }
                if (mark == 2 || mark == 3 || mark == 4 || mark ==5)
                {
                    double[] t = Marks;
                    Marks = new double[t.Length + 1];
                    for (int i = 0; i < t.Length; i++)
                    {
                        Marks[i] = t[i];
                    }
                    Marks[t.Length] = mark;
                }
            }
            public Student(string _Name, string _Surname)
            {
                surname = _Surname;
                name = _Name;
                skipped = 0;
                Marks = new double[0];
            }
            public void Student_(string _Name, string _Surname)
            {
                surname = _Surname;
                name = _Name;
                skipped = 0;
                Marks = new double[0];
            }
            public void Print()
            {
                if (surname == null || name == null) return;
                Console.Write(Name);
                Console.Write(" ");
                Console.Write(Surname);
                Console.Write(" ");
                Console.Write(AvgMark);
                Console.Write(" ");
                Console.WriteLine(Skipped);
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
