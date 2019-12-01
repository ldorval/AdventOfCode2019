using System.Linq;

namespace AdventOfCode.Day01
{
    public class Day1Part2
    {
        public static long GetNeededFuel(long mass)
        {
            var fuel = Day1Part1.GetNeededFuel(mass);

            if (fuel > 0)
                return fuel + GetNeededFuel(fuel);

            return 0;
        }

        public static long GetTotalFuel()
        {
            var masses = InputReader.ReadLinesLong("Day01/Input.txt");
            return masses.Sum(GetNeededFuel);
        }
    }
}