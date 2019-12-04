using System.Collections.Generic;
using AdventOfCode;
using NUnit.Framework;

namespace AdventOfCodeTest
{
    public class InputReaderTest
    {
        [Test]
        public void ReadAllReturnsEntireFileContent()
        {
            var content = InputReader.ReadAll("DayTest/DayTestPart1.txt");
            Assert.That(content, Is.EqualTo("144\r\n218"));
        }

        [Test]
        public void ReadLinesReturnListOfLines()
        {
            var lines = InputReader.ReadLines("DayTest/DayTestPart1.txt");
            Assert.That(lines, Is.EquivalentTo(new List<string> { "144", "218" }));
        }

        [Test]
        public void ReadLinesAsInt()
        {
            var lines = InputReader.ReadLinesInt("DayTest/DayTestPart1.txt");
            Assert.That(lines, Is.EquivalentTo(new List<int> { 144, 218 }));
        }
        
        [Test]
        public void ReadLinesAsLong()
        {
            var lines = InputReader.ReadLinesLong("DayTest/DayTestPart1.txt");
            Assert.That(lines, Is.EquivalentTo(new List<long> { 144, 218 }));
        }

        [Test]
        public void ReadIntCsv()
        {
            var ints = InputReader.ReadIntCsv("DayTest/IntCsv.txt");
            Assert.That(ints, Is.EquivalentTo(new List<int> { 12, 14, 2, 5 }));
        }

        [Test]
        public void ReadStringCsv()
        {
            var ints = InputReader.ReadCsv("DayTest/IntCsv.txt");
            Assert.That(ints, Is.EquivalentTo(new List<string> { "12", "14", "2", "5" }));
        }
    }
}