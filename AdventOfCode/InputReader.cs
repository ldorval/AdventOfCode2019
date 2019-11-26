using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public static class InputReader
    {
        public static string ReadAll(string file)
        {
            return File.ReadAllText(PathFrom(file));
        }

        public static List<string> ReadLines(string file)
        {
            return File.ReadAllLines(PathFrom(file)).ToList();
        }

        private static string PathFrom(string file)
        {
            return $"../../../../AdventOfCode/{file}";
        }
    }
}