using System.Collections.Generic;

namespace AdventOfCode.Day02
{
    public class Day2Part1
    {
        public static List<int> Result(List<int> input, int noun, int verb)
        {
            input[1] = noun;
            input[2] = verb;
            
            for (var i = 0; i < input.Count; i += 4)
            {
                if (input[i] == 99)
                    return input;
                
                var op = input[i];
                var first = input[input[i + 1]];
                var second = input[input[i + 2]];
                var pos = input[i + 3];

                if (op == 1)
                    input[pos] = first + second;
                else
                    input[pos] = first * second;
            }

            return input;
        }
    }
}