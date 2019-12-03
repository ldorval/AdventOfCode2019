using System;
using System.Linq;
using AdventOfCode;
using AdventOfCode.Day02;
using NUnit.Framework;

namespace AdventOfCodeTest.Day02
{
    public class Day2Part1Test
    {
        [Test]
        public void Example1()
        {
            var input = "1,0,0,0,99".Split(",").Select(x => Convert.ToInt32(x)).ToList();
            var result = Day2Part1.Result(input, 0, 0);
            
            Assert.That(result[0], Is.EqualTo(2));
        }
        
        [Test]
        public void Example2()
        {
            var input = "2,3,0,3,99".Split(",").Select(x => Convert.ToInt32(x)).ToList();
            var result = Day2Part1.Result(input, 3, 0);
            
            Assert.That(result[3], Is.EqualTo(6));
        }
        
        [Test]
        public void Example3()
        {
            var input = "2,4,4,5,99,0".Split(",").Select(x => Convert.ToInt32(x)).ToList();
            var result = Day2Part1.Result(input, 4, 4);
            
            Assert.That(result[5], Is.EqualTo(9801));
        }
        
        [Test]
        public void Example4()
        {
            var input = "1,1,1,4,99,5,6,0,99".Split(",").Select(x => Convert.ToInt32(x)).ToList();
            var result = Day2Part1.Result(input, 1, 1);
            
            Assert.That(result[0], Is.EqualTo(30));
            Assert.That(result[4], Is.EqualTo(2));
        }

        [Test]
        public void Solution()
        {
            var input = InputReader.ReadIntCsv("Day02/Input.txt");
            var result = Day2Part1.Result(input, 12, 2);
            Console.WriteLine(result[0]);
        }
    }
}