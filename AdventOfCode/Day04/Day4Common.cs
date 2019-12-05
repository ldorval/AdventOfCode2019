namespace AdventOfCode.Day04
{
    public class Day4Common
    {
        public static bool GoesIncreasingly(int password)
        {
            var passwordStr = password.ToString();
            var previous = '0';
            
            foreach (var c in passwordStr)
            {
                if (previous > c)
                    return false;

                previous = c;
            }

            return true;
        }
    }
}