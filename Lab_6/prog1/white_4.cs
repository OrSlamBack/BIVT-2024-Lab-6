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
    public class White_4
    {
        public struct Participant
        {
            private string Surname, Name;

            private double[] Scores;
            public string surname => Surname;
            public string name => Name;
            public double[] scores => Scores;
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
                Scores = new double[t.Length+1];
                for(int i = 0;i < t.Length; i++)
                {
                    Scores[i] = t[i];
                }
                Scores[t.Length] = result;
            }
            public Participant(string _Surname, string _Name)
            {
                Surname = _Surname;
                Name = _Name;
                Scores = new double[0];
            }
            public void Print()
            {
                if(surname == null ||  name == null || scores == null) return;
                Console.Write(surname);
                Console.Write(" ");
                Console.Write(name);
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
