using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020
{
    public class Day05
    {
        static Dictionary<int, string> _seatIDs = new Dictionary<int, string>();


        public static int Day5Part1(List<string> input)
        {
            int highestSeatID = 0;

            foreach (string line in input)
            {
                //find row
                int row = GetRow(line);

                //find column
                int column = GetColumn(line);


                //calculate seatID
                int seatID = row * 8 + column;

                if (seatID > highestSeatID)
                {
                    highestSeatID = seatID;
                }
            }

            return highestSeatID;
        }

        public static int Day5Part2(List<string> input)
        {
            _seatIDs.Clear();
            int lowestSeatID = input.Count;
            int highestSeatID = 0;

            foreach (string line in input)
            {
                //find row
                int row = GetRow(line);

                //find column
                int column = GetColumn(line);


                //calculate seatID
                int seatID = row * 8 + column;
                _seatIDs.Add(seatID, "");

                if (seatID < lowestSeatID)
                {
                    lowestSeatID = seatID;
                }

                if (seatID > highestSeatID)
                {
                    highestSeatID = seatID;
                }
            }

            //find my seat
            for (int i = lowestSeatID + 1; i < highestSeatID; i++)
            {
                if (!_seatIDs.ContainsKey(i))
                {
                    return i;
                }
            }

            return 0;
        }


        public static int GetRow(string input)
        {
            string rowString = input.Substring(0, 7);

            int minRow = 0;
            int maxRow = 127;

            for (int i = 0; i < rowString.Length; i++)
            {
                if (rowString[i].Equals('F'))
                {
                    //F means take the 'lower half'
                    int span = (maxRow - minRow) + 1;
                    maxRow = maxRow - (span / 2);
                }
                else
                {
                    int span = (maxRow - minRow) + 1;
                    minRow = minRow + (span / 2);
                }
            }

            if (minRow == maxRow)
            {
                return minRow;
            }

            return 0;
        }

        public static int GetColumn(string input)
        {
            string columnString = input.Substring(7);

            int minColumn = 0;
            int maxColumn = 7;

            for (int i = 0; i < columnString.Length; i++)
            {
                if (columnString[i].Equals('L'))
                {
                    //L means take the 'lower half'
                    int span = (maxColumn - minColumn) + 1;
                    maxColumn = maxColumn - (span / 2);
                }
                else
                {
                    int span = (maxColumn - minColumn) + 1;
                    minColumn = minColumn + (span / 2);
                }
            }

            if (minColumn == maxColumn)
            {
                return minColumn;
            }

            return 0;
        }

        public static int GetSeatID(int row, int column)
        {
            int seatID = row * 8 + column;
            return seatID;
        }
    }
}
