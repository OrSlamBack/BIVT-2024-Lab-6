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
    public class White_5
    {
        public struct Match
        {
            private readonly int Goals;
            private readonly int Misses;
            public int goals => Goals;
            public int misses => Misses;
            public int Difference
            {
                get
                {
                    return Goals - Misses;
                }
            }
            public int Score
            {
                get
                {
                    if(Difference > 0)
                    {
                        return 3;
                    }
                    if (Difference == 0) {
                        return 1;
                    }
                    return 0;
                }
            }
            public Match(int _goals, int _misses)
            {
                Goals = _goals;
                Misses = _misses;
            }
            public void Print()
            {
                Console.WriteLine();
                Console.WriteLine($"Голов : {goals}");
                Console.WriteLine($"Пропущено : {misses}");
                Console.WriteLine($"Очков : {Score}");
            }
        };
        public struct Team
        {
            private string Name;
            private Match[] Matches;
            public string name => Name;
            public Match[] matches => Matches;
            public int TotalDifference
            {
                get
                {
                    int res = 0;
                    for(int i = 0;i < Matches.Length; i++)
                    {
                        res += Matches[i].Difference;
                    }
                    return res;
                }
            }
            public int TotalScore
            {
                get
                {
                    int res = 0;
                    for (int i = 0; i < Matches.Length; i++)
                    {
                        res += Matches[i].Score;
                    }
                    return res;
                }
            }
            public Team(string _name) { 
                Name = _name;
                Matches = new Match[0];
            }
            public void PlayMatch(int goals, int misses)
            {
                Match[] t = Matches;
                Matches = new Match[t.Length + 1];
                for (int i = 0; i < t.Length; i++)
                {
                    Matches[i] = t[i];
                }
                Matches[t.Length + 1] = new Match(goals, misses);
            }
            public static void Sort(Team[] array)
            {
                if(array == null)
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
            public void Print()
            {
                if (name == null) return;
                if(matches == null) return;
                Console.WriteLine(name);
                Console.WriteLine($"Количество матчей {matches.Length}");
                Console.WriteLine("Результаты матчей");
                for (int i = 0; i < matches.Length; i++) {
                    matches[i].Print();
                }
            }
        };

    }
}
