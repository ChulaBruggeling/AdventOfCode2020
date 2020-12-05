using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2020
{
    public class Day02
    {
        public static int Day2Part1(List<string> input)
        {
            int count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                int position1 = input[i].IndexOf("-");
                int position2 = input[i].IndexOf(" ");
                int position3 = input[i].IndexOf(":");
                int position4 = input[i].LastIndexOf(" ");

                int min = int.Parse(input[i].Substring(0, position1));
                int max = int.Parse(input[i].Substring(position1 + 1, position2 - position1));
                string letter = input[i].Substring(position2 + 1, position3 - position2 - 1);
                string password = input[i].Substring(position4 + 1);

                char ch = char.Parse(letter);
                int lettercount = password.Count(i => (i == ch));

                if (lettercount >= min && lettercount <= max)
                {
                    count++;
                }
            }

            return count;
        }

        public static int Day2Part2(List<string> input)
        {
            int count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                int position1 = input[i].IndexOf("-");
                int position2 = input[i].IndexOf(" ");
                int position3 = input[i].IndexOf(":");
                int position4 = input[i].LastIndexOf(" ");

                int pos1 = int.Parse(input[i].Substring(0, position1));
                int pos2 = int.Parse(input[i].Substring(position1 + 1, position2 - position1));
                char letter = char.Parse(input[i].Substring(position2 + 1, position3 - position2 - 1));
                string password = input[i].Substring(position4 + 1);

                if (char.Parse(password.Substring(pos1 - 1, 1)) == letter && char.Parse(password.Substring(pos2 - 1, 1)) != letter)
                {
                    count++;
                }
                else if (char.Parse(password.Substring(pos1 - 1, 1)) != letter && char.Parse(password.Substring(pos2 - 1, 1)) == letter)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
