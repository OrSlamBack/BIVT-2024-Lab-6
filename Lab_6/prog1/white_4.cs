using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_6
{
    public class White_4
    {
        public struct Participant
        {
            private string surname, name;

            private double[] scores;
            public string Surname => surname;
            public string Name => name;
            public double[] Scores => scores;
            public double TotalScore
            {
                get
                {
                    double sum = 0;
                    for (int i = 0; i < Scores.Length; i++)
                    {
                        sum += Scores[i];
                    }
                    return sum;
                }
            }
            public void PlayMatch(double result)
            {
                double[] t = Scores;
                scores = new double[t.Length+1];
                for(int i = 0;i < t.Length; i++)
                {
                    Scores[i] = t[i];
                }
                Scores[t.Length] = result;
            }
            public Participant(string _Surname, string _Name)
            {
                surname = _Surname;
                name = _Name;
                scores = new double[0];
            }
            public void Print()
            {
                if(Surname == null ||  Name == null || Scores == null) return;
                Console.Write(surname);
                Console.Write(" ");
                Console.Write(Name);
                Console.Write(" ");
                Console.Write("Scores : ");
                for (int i = 0; i < Scores.Length; i++)
                {
                    Console.Write(Scores[i] + " ");
                }
                Console.WriteLine();
            }
            public static void Sort(Participant[] array)
            {
                if (array == null)
                {
                    return;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j].TotalScore > array[i].TotalScore)
                        {
                            (array[i], array[j]) = (array[j], array[i]);
                        }
                    }
                }
            }
                
        };

    }
}
