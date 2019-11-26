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
            Assert.That(content, Is.EqualTo("bacon\r\npatate"));
        }

        [Test]
        public void ReadLinesReturnListOfLines()
        {
            var lines = InputReader.ReadLines("DayTest/DayTestPart1.txt");
            Assert.That(lines, Is.EquivalentTo(new List<string> { "bacon", "patate" }));
        }
    }
}