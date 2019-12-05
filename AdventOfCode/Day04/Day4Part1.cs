using System.Collections.Generic;

namespace AdventOfCode.Day04
{
    public class Day4Part1
    {
        public static int Solution1(int start, int end)
        {
            var validPasswords = new List<int>();

            for (var i = start; i <= end; i++)
            {
                if (Day4Common.GoesIncreasingly(i) && HasDouble(i))
                    validPasswords.Add(i);
            }

            return validPasswords.Count;
        }

        private static bool HasDouble(int password)
        {
            var passwordStr = password.ToString();
            var previous = '0';

            foreach (var c in passwordStr)
            {
                if (previous == c) return true;
                previous = c;
            }

            return false;
        }
    }
}