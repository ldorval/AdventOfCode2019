using System;
using AdventOfCode;
using AdventOfCode.Day03;
using NUnit.Framework;

namespace AdventOfCodeTest.Day03
{
    public class Day3Part2Test
    {
        [Test]
        public void Example1()
        {
            var inputWire1 = "R75,D30,R83,U83,L12,D49,R71,U7,L72".ToValueList();
            var inputWire2 = "U62,R66,U55,R34,D71,R55,D58,R83".ToValueList();
            
            Assert.That(new Day3().Solution2(inputWire1, inputWire2), Is.EqualTo(610));
        }
        
        [Test]
        public void Example2()
        {
            var inputWire1 = "R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51".ToValueList();
            var inputWire2 = "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7".ToValueList();
            
            Assert.That(new Day3().Solution2(inputWire1, inputWire2), Is.EqualTo(410));
        }

        [Test]
        public void Solution()
        {
            var inputWire1 = InputReader.ReadCsv("Day03/wire1.txt");
            var inputWire2 = InputReader.ReadCsv("Day03/wire2.txt");
            
            Console.WriteLine(new Day3().Solution2(inputWire1, inputWire2));
        }
    }
}