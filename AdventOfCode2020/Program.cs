using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int output;

            #region Day 01
            Console.WriteLine("Advent of Code - Day 01");

            output = Day01.Day1Part1(InputHelper.InputToIntList(1));
            Console.WriteLine("Part 1: " + output);

            output = Day01.Day1Part2(InputHelper.InputToIntList(1));
            Console.WriteLine("Part 2: " + output);

            Console.WriteLine();
            #endregion Day 01

            #region Day 02
            Console.WriteLine("Advent of Code - Day 02");

            output = Day02.Day2Part1(InputHelper.InputToStringList(2));
            Console.WriteLine("Part 1: " + output);

            output = Day02.Day2Part2(InputHelper.InputToStringList(2));
            Console.WriteLine("Part 2: " + output);

            Console.WriteLine();
            #endregion Day 02

            #region Day 03
            Console.WriteLine("Advent of Code - Day 03");

            output = Day03.Day3Part1(InputHelper.InputToStringList(3), 3, 1);
            Console.WriteLine("Part 1: " + output);

            var input = InputHelper.InputToStringList(3);
            int count1 = Day03.Day3Part1(input, 1, 1);
            int count2 = Day03.Day3Part1(input, 3, 1);
            int count3 = Day03.Day3Part1(input, 5, 1);
            int count4 = Day03.Day3Part1(input, 7, 1);
            int count5 = Day03.Day3Part1(input, 1, 2);
            //TODO: bug - number is too large, overflow
            output = count1 * count2 * count3 * count4 * count5;
            Console.WriteLine("Part 2: " + output);

            Console.WriteLine();
            #endregion Day 03

            #region Day 04
            Console.WriteLine("Advent of Code - Day 04");

            output = Day04.Day4Part1(InputHelper.InputToStringList(4));
            Console.WriteLine("Part 1: " + output);

            output = Day04.Day4Part2(InputHelper.InputToStringList(4));
            Console.WriteLine("Part 2: " + output);

            Console.WriteLine();
            #endregion Day 04
        }
    }
}
