using System.Collections.Generic;

namespace AdventOfCode.Day02
{
    public class Day2Part2
    {
        public static int Result(List<int> input)
        {
            for (var i = 0; i < 100; i++)
            {
                for (var j = 0; j < 100; j++)
                {
                    var freshInput = new List<int>(input);
                    if (Day2Part1.Result(freshInput, i, j)[0] == 19690720)
                        return 100 * i + j;
                }
            }

            return 0;
        }
        
    }
}