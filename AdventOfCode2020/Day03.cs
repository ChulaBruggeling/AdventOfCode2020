using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020
{
    public class Day03
    {
        public static int Day3Part1(List<string> input, int xSlope, int ySlope)
        {
            //build map
            var yLength = input.Count;
            var xLength = input[0].Length;
            char[,] map = new char[yLength, xLength];

            for (int y = 0; y < yLength; y++)
            {
                for (int x = 0; x < xLength; x++)
                {
                    map[y, x] = input[y][x];
                }
            }

            //count Trees
            int cordY = 0;
            int cordX = 0;

            int countTrees = 0;
            int countOpen = 0;

            while (cordY < yLength)
            {
                if (map[cordY, cordX].Equals('#'))
                {
                    countTrees++;
                }
                else
                {
                    countOpen++;
                }
                cordY = cordY + ySlope;
                cordX = (cordX + xSlope) % xLength;
            }

            return countTrees;
        }
    }
}
