using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020
{
    class Day06
    {
        public static int Day6Part1(List<string> input)
        {
            List<char> answeredYesList = new List<char>();
            int output = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] != "")
                {
                    foreach (char c in input[i])
                    {
                        if (!answeredYesList.Contains(c))
                        {
                            answeredYesList.Add(c);
                        }
                    }
                }
                else
                {
                    //check list, add, clear list
                    output = output + answeredYesList.Count;
                    answeredYesList.Clear();
                }
            }

            //check list, add
            output = output + answeredYesList.Count;

            return output;
        }

        public static int Day6Part2(List<string> input)
        {
            List<char> answeredYesList = new List<char>();
            List<char> tempAnsweredYesList = new List<char>();

            int output = 0;

            bool isFirst = true;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] != "")
                {
                    if (isFirst)
                    {
                        foreach (char c in input[i])
                        {
                            answeredYesList.Add(c);
                        }
                        isFirst = false;
                    }
                    else
                    {
                        foreach (char c in answeredYesList)
                        {
                            if (input[i].Contains(c))
                            {
                                tempAnsweredYesList.Add(c);
                            }
                        }

                        answeredYesList.Clear();
                        foreach (char c in tempAnsweredYesList)
                        {
                            answeredYesList.Add(c);
                        }
                        tempAnsweredYesList.Clear();
                    }
                }
                else
                {
                    //check list, add, clear list
                    output = output + answeredYesList.Count;

                    //setup for next group
                    answeredYesList.Clear();
                    isFirst = true;
                }
            }

            //check list, add
            output = output + answeredYesList.Count;

            return output;
        }
    }
}
