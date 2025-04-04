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
    public class White_1
    {
        public struct Participant
        {
            private string Surname, Club;
            private double FirstJump, SecondJump;
            public string surname => Surname;
            public string club => Club;
            public double firstjump => FirstJump;
            public double secondjump => SecondJump;

            public double JumpSum { get { return FirstJump + SecondJump; } }
            public Participant(string _Surname, string _Club)
            {
                Surname = _Surname;
                Club = _Club;
                FirstJump = 0;
                SecondJump = 0;
            }
            public void Jump(double result)
            {
                    if (FirstJump == 0)
                    {
                        FirstJump = result;
                    }

                else if (SecondJump == 0)
                {
                    SecondJump = result;
                }
            }
            public void Print()
            {
                if(surname == null || club == null)
                {
                    return;
                }
                Console.Write(surname);
                Console.Write(" ");
                Console.Write(club);
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
                        if (array[j].FirstJump > array[i].FirstJump)
                        {
                            (array[i], array[j]) = (array[j], array[i]);
                        }
                    }
                }
            }

        };

    }
}
