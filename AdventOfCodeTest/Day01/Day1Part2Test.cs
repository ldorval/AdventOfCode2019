using System;
using AdventOfCode.Day01;
using NUnit.Framework;

namespace AdventOfCodeTest.Day01
{
    public class Day1Part2Test
    {
        [Test]
        public void Example1()
        {
            Assert.That(Day1Part2.GetNeededFuel(14), Is.EqualTo(2));            
        }
        
        [Test]
        public void Example2()
        {
            Assert.That(Day1Part2.GetNeededFuel(1969), Is.EqualTo(966));            
        }
        
        [Test]
        public void Example3()
        {
            Assert.That(Day1Part2.GetNeededFuel(100756), Is.EqualTo(50346));            
        }

        [Test]
        public void Solution()
        {
            Console.WriteLine(Day1Part2.GetTotalFuel());            
        }
    }
}