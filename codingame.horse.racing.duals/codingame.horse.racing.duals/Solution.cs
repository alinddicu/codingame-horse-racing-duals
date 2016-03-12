namespace codingame.horse.racing.duals
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;

    /**
     * Auto-generated code below aims at helping you parse
     * the standard input according to the problem statement.
     **/
    class Solution
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var strengths = new List<int>();
            for (int i = 0; i < N; i++)
            {
                strengths.Add(int.Parse(Console.ReadLine()));
            }

            strengths = strengths.OrderBy(s => s).ToList();
            var diffs = new List<int>();
            for (var i = 0; i < strengths.Count - 1; i++)
            {
                diffs.Add(strengths[i + 1] - strengths[i]);
            }

            Console.WriteLine(diffs.Min(d => d));
        }
    }
}
