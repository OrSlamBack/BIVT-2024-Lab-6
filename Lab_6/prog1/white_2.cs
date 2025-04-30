using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Lab_6
{
    public class White_2
    {
        public struct Participant
        {
            private string surname, name;
            private double firstJump, secondJump;
            public string Name { get { return name; } }
            public string Surname { get { return surname; } }
            public double FirstJump { get { return firstJump; } }
            public double SecondJump { get { return secondJump; } }

            public double BestJump 
            { 
                get 
                { 
                    if(firstJump == -1 && secondJump == -1)
                    {
                        return 0;
                    }
                    return Math.Max(FirstJump, SecondJump); 
                } 
            }
            public Participant(string _Name,string _Surname)
            {
                surname = _Surname;
                name = _Name;
                firstJump = -1; secondJump = -1;
            }
            public void Participant_(string _Name, string _Surname)
            {
                surname = _Surname;
                name = _Name;
                firstJump = -1; secondJump = -1;
            }
            public void Jump(double result)
            {
                if(result < 0)
                {
                    return;
                }
                if (FirstJump == -1)
                {
                    firstJump = result;
                }
                else if (SecondJump == -1)
                {
                    secondJump = result;
                }
            }
            public void Print()
            {
                if (Surname == null || Name == null) return;
                Console.Write(Name);
                Console.Write(" ");
                Console.Write(Surname);
                Console.Write(" ");
                Console.Write(FirstJump);
                Console.Write(" ");
                Console.WriteLine(SecondJump);
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
                        if (array[j].BestJump > array[i].BestJump)
                        {
                            (array[i], array[j]) = (array[j], array[i]);
                        }
                    }
                }
            }

        };

    }
}
