using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AdventOfCode.Day03
{
    public class Day3
    {
        private Point cursor = new Point(0, 0);
        
        public int Solution1(List<string> inputWire1, List<string> inputWire2)
        {
            var wire1Coordinates = MoveWire(inputWire1);
            var wire2Coordinates = MoveWire(inputWire2);
            var intersections = wire1Coordinates.Intersect(wire2Coordinates).ToList();
            
            return intersections.Select(a => Math.Abs(a.X) + Math.Abs(a.Y)).OrderBy(a => a).First();
        }

        public int Solution2(List<string> inputWire1, List<string> inputWire2)
        {
            var wire1Coordinates = MoveWire(inputWire1);
            var wire2Coordinates = MoveWire(inputWire2);
            var intersections = wire1Coordinates.Intersect(wire2Coordinates).ToList();

            var stepsWire1 = wire1Coordinates.IndexOf(intersections.First()) + 1;
            var stepsWire2 = wire2Coordinates.IndexOf(intersections.First()) + 1;

            return stepsWire1 + stepsWire2;
        }

        private List<Point> MoveWire(List<string> inputWire)
        {
            cursor = new Point(0,0);
            var coordinates = new List<Point>();

            foreach (var entry in inputWire)
            {
                coordinates.AddRange(GetNewCoordinates(entry));
            }

            return coordinates;
        }

        private List<Point> GetNewCoordinates(string entry)
        {
            var direction = entry.Substring(0, 1);
            var distance = Convert.ToInt32(entry.Substring(1, entry.Length - 1));
            var coordinates = new List<Point>();
            
            for (var i = 0; i < distance; i++)
            {
                if (direction == "R") cursor.X += 1;
                else if (direction == "L") cursor.X -= 1;
                else if (direction == "U") cursor.Y += 1;
                else if (direction == "D") cursor.Y -= 1;

                coordinates.Add(new Point(cursor.X, cursor.Y));
            }

            return coordinates;
        }
    }
}
