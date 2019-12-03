using System;
using AdventOfCode;
using AdventOfCode.Day02;
using NUnit.Framework;

namespace AdventOfCodeTest.Day02
{
    public class Day2Part2Test
    {
        [Test]
        public void Solution()
        {
            var input = InputReader.ReadIntCsv("Day02/Input.txt");
            Console.WriteLine(Day2Part2.Result(input));
        }
    }
}