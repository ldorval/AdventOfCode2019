using System;
using System.Linq;

namespace AdventOfCode.Day01
{
    public class Day1Part1
    {
        public static long GetNeededFuel(long mass)
        {
            return Convert.ToInt64(Math.Floor(mass / 3.0)) - 2;
        }

        public static long GetTotalFuel()
        {
            var masses = InputReader.ReadLinesLong("Day01/Input.txt");
            return masses.Sum(GetNeededFuel);
        }
    }
}