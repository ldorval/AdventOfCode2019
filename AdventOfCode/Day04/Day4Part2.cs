using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day04
{
    public class Day4Part2
    {
        public static int Solution(int start, int end)
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

            foreach (var digit in passwordStr)
            {
                var count = passwordStr.Count(c => c == digit);

                if (count == 2)
                    return true;
            }

            return false;
        }
    }
}