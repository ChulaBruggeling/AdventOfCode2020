using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020
{
    public class Day04
    {
        public static int Day4Part1(List<string> input)
        {
            int validPassportCount = 0;
            Dictionary<string, string> passportData = new Dictionary<string, string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] != "")
                {
                    string[] data = input[i].Split(" ");
                    foreach (string s in data)
                    {
                        int splitIndex = s.IndexOf(":");
                        passportData.Add(s.Substring(0, splitIndex), s.Substring(splitIndex + 1));
                    }
                } 
                else
                {
                    //Validate passport
                    if (ValidatePassport(passportData))
                    {
                        validPassportCount++;
                    }

                    passportData.Clear();
                }
            }

            //file might end with last passportdata without newline, make sure to check not to miss this one
            if (ValidatePassport(passportData))
            {
                validPassportCount++;
            }

            return validPassportCount;
        }

        public static int Day4Part2(List<string> input)
        {
            int validPassportCount = 0;
            Dictionary<string, string> passportData = new Dictionary<string, string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] != "")
                {
                    string[] data = input[i].Split(" ");
                    foreach (string s in data)
                    {
                        int splitIndex = s.IndexOf(":");
                        passportData.Add(s.Substring(0, splitIndex), s.Substring(splitIndex + 1));
                    }
                }
                else
                {
                    //Validate passport
                    if (ValidatePassportStrict(passportData))
                    {
                        validPassportCount++;
                    }

                    passportData.Clear();
                }
            }

            //file might end with last passportdata without newline, make sure to check not to miss this one
            if (ValidatePassportStrict(passportData))
            {
                validPassportCount++;
            }

            return validPassportCount;
        }

        private static bool ValidatePassport(Dictionary<string, string> passport)
        {
            bool isValid = true;

            if (!(passport.Count == 8 || passport.Count == 7))
            {
                isValid = false;
            }
            else if (!passport.ContainsKey("byr"))
            {
                isValid = false;
            }
            else if (!passport.ContainsKey("iyr"))
            {
                isValid = false;
            }
            else if (!passport.ContainsKey("eyr"))
            {
                isValid = false;
            }
            else if (!passport.ContainsKey("hgt"))
            {
                isValid = false;
            }
            else if (!passport.ContainsKey("hcl"))
            {
                isValid = false;
            }
            else if (!passport.ContainsKey("ecl"))
            {
                isValid = false;
            }
            else if (!passport.ContainsKey("pid"))
            {
                isValid = false;
            }

            return isValid;
        }

        private static bool ValidatePassportStrict(Dictionary<string, string> passport)
        {
            bool isValid = true;

            if (!(passport.Count == 8 || passport.Count == 7))
            {
                isValid = false;
            }

            else if (!ValidateByr(passport))
            {
                isValid = false;
            }

            else if (!ValidateIyr(passport))
            {
                isValid = false;
            }

            else if (!ValidateEyr(passport))
            {
                isValid = false;
            }

            else if (!ValidateHgt(passport))
            {
                isValid = false;
            }

            else if (!ValidateHcl(passport))
            {
                isValid = false;
            }

            else if (!ValidateEcl(passport))
            {
                isValid = false;
            }

            else if (!ValidatePid(passport))
            {
                isValid = false;
            }

            return isValid;
        }

        private static bool ValidateByr(Dictionary<string, string> passport)
        {
            if (passport.ContainsKey("byr"))
            {
                int byr = int.Parse(passport["byr"]);
                if (byr >= 1920 && byr <= 2002)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidateIyr(Dictionary<string, string> passport)
        {
            if (passport.ContainsKey("iyr"))
            {
                int byr = int.Parse(passport["iyr"]);
                if (byr >= 2010 && byr <= 2020)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidateEyr(Dictionary<string, string> passport)
        {
            if (passport.ContainsKey("eyr"))
            {
                int byr = int.Parse(passport["eyr"]);
                if (byr >= 2020 && byr <= 2030)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidateHgt(Dictionary<string, string> passport)
        {
            if (passport.ContainsKey("hgt"))
            {
                try
                {
                    string heightString = passport["hgt"].Substring(passport["hgt"].Length - 2);
                    int heightInt = int.Parse(passport["hgt"].Substring(0, passport["hgt"].Length - 2));
                    if (heightString == "cm" && heightInt >= 150 && heightInt <= 193)
                    {
                        return true;
                    }
                    else if (heightString == "in" && heightInt >= 59 && heightInt <= 76)
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }


            }
            return false;
        }

        public static bool ValidateHcl(Dictionary<string, string> passport)
        {
            char[] validCharacters = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
            if (passport.ContainsKey("hcl"))
            {
                if (passport["hcl"][0].Equals('#'))
                {
                    string code = passport["hcl"].Substring(1);
                    if (code.Length == 6)
                    {
                        foreach (char c in code)
                        {
                            bool isValidChar = false;
                            foreach (char vc in validCharacters)
                            {
                                if (c.Equals(vc))
                                {
                                    isValidChar = true;
                                }
                            }

                            if (!isValidChar)
                            {
                                return false;
                            }
                        }

                        return true;
                    }
                }

            }
            return false;
        }

        private static bool ValidateEcl(Dictionary<string, string> passport)
        {
            if (passport.ContainsKey("ecl"))
            {
                string[] validEyeColors = new string[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

                if (passport["ecl"].Length == 3)
                {
                    bool isValidColor = false;
                    foreach (string s in validEyeColors)
                    {
                        if (passport["ecl"].Equals(s))
                        {
                            isValidColor = true;
                        }
                    }

                    if (isValidColor)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool ValidatePid(Dictionary<string, string> passport)
        {
            if (passport.ContainsKey("pid"))
            {
                if (passport["pid"].Length == 9)
                {


                    StringBuilder sb = new StringBuilder();
                    //bool tryingLeadingZeroes = true;
                    foreach (char c in passport["pid"])
                    {
                        //if (char.IsDigit(c))
                        //{
                        //    if (tryingLeadingZeroes && c.Equals('0'))
                        //    {

                        //    }
                        //    else
                        //    {
                        //        tryingLeadingZeroes = false;
                        //        sb.Append(c);
                        //    }
                        //}
                        //else
                        //{
                        //    return false;
                        //}
                        if (!char.IsDigit(c))
                        {
                            return false;
                        }
                    }
                    return true;
                }

            }
            return false;
        }
    }
}
