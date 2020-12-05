using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020
{
    public class Day01
    {
        public static int Day1Part1(List<int> input)
        {
            foreach (int number in input)
            {
                foreach (int numberAgain in input)
                {
                    if (number + numberAgain == 2020)
                    {
                        return number * numberAgain;
                    }
                }
            }

            return 0;
        }

        public static int Day1Part2(List<int> input)
        {
            foreach (int number1 in input)
            {
                foreach (int number2 in input)
                {
                    if (number1 + number2 < 2020)
                    {
                        foreach (int number3 in input)
                        {
                            if (number1 + number2 + number3 == 2020)
                            {
                                return number1 * number2 * number3;
                            }
                        }
                    }
                }
            }

            return 0;
        }
    }
}
