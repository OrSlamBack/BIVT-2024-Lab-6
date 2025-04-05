using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_6
{
    public class White_1
    {
        public struct Participant
        {
            private string surname, club;
            private double firstJump, secondJump;
            public string Surname  { get { return surname; } }
            public string Club { get { return club; } }
            public double FirstJump { get { return firstJump; } }
            public double SecondJump { get { return secondJump; } }

            public double JumpSum { get { return (FirstJump + SecondJump); } }
            public Participant(string _Surname, string _Club)
            {
                surname = _Surname;
                club = _Club;
                firstJump = 0;
                secondJump = 0;
            }
            public void Jump(double result)
            {
                    if (firstJump == 0)
                    {
                        firstJump = result;
                    }

                else if (secondJump == 0)
                {
                    secondJump = result;
                }
            }
            public void Print()
            {
                if(Surname == null || Club == null)
                {
                    return;
                }
                Console.Write(Surname);
                Console.Write(" ");
                Console.Write(Club);
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
                        if (array[j].JumpSum > array[i].JumpSum)
                        {
                            (array[i], array[j]) = (array[j], array[i]);
                        }
                    }
                }
            }

        };

    }
}
