using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2020
{
    public static class InputHelper
    {
        public static List<string> InputToStringList(string filePath)
        {
            List<string> input = new List<string>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    input.Add(line);
                }
            }

            return input;
        }

        public static List<string> InputToStringList(int dayNumber)
        {
            List<string> input = new List<string>();

            string filePath = $"C:\\Users\\Chula\\Desktop\\AOC_Input\\Day{dayNumber}Input.txt";

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    input.Add(line);
                }
            }

            return input;
        }

        public static List<int> InputToIntList(int dayNumber)
        {
            List<int> input = new List<int>();

            string filePath = $"C:\\Users\\Chula\\Desktop\\AOC_Input\\Day{dayNumber}Input.txt";

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    input.Add(int.Parse(line));
                }
            }

            return input;
        }
    }
}
