using System;
using AdventOfCode.Day01;
using NUnit.Framework;

namespace AdventOfCodeTest.Day01
{
    public class Day1Part1Test
    {
        [Test]
        public void Example1()
        {
            Assert.That(Day1Part1.GetNeededFuel(12), Is.EqualTo(2));            
        }
        
        [Test]
        public void Example2()
        {
            Assert.That(Day1Part1.GetNeededFuel(14), Is.EqualTo(2));            
        }
        
        [Test]
        public void Example3()
        {
            Assert.That(Day1Part1.GetNeededFuel(1969), Is.EqualTo(654));            
        }
        
        [Test]
        public void Example4()
        {
            Assert.That(Day1Part1.GetNeededFuel(100756), Is.EqualTo(33583));            
        }

        [Test]
        public void Solution()
        {
            Console.WriteLine(Day1Part1.GetTotalFuel());
        }
    }
}