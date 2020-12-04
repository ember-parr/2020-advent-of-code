using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


namespace advent_of_code
{
    class DayTwo
    {
        public void PartOne()
        {
            var logFile = File.ReadAllLines("DayTwo.txt");
            var logList = new List<string>(logFile);
            int answer = 0;


            for (int i = 0; i < logFile.Length; i++)
            {
                string[] sections = logFile[i].Split(": ");
                string[] splitFirstSection = sections[0].Split(" ");
                string[] splitNumber = splitFirstSection[0].Split("-");
                string[] ArrayedSingleLetter = splitFirstSection[1].Split(" ");
                string splitSingleLetter = ArrayedSingleLetter[0];

                int firstNumber = int.Parse(splitNumber[0]);
                int secondNumber = int.Parse(splitNumber[1]);

                string password = sections[1];

                var goodCharacters = password.Where(letter => splitSingleLetter.Contains(letter));

                string allowedChars = new string(goodCharacters.ToArray());

                int countOfAllowedChars = allowedChars.Length;


                if (countOfAllowedChars <= secondNumber && countOfAllowedChars >= firstNumber)
                {
                    answer++;
                }


            }
            Console.WriteLine($"Answer: {answer}");
        }
    }
}