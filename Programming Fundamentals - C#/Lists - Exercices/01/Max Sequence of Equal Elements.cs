using System;
using System.Collections.Generic;
using System.Linq;


namespace _01
{
    public class Program
    {
        public static void Main()
        {
            string[] inputNums = Console.ReadLine()
                .Split();

            int[] parsedNums = new int[inputNums.Length];

            for (int i = 0; i < inputNums.Length; i++)
            {
                parsedNums[i] = int.Parse(inputNums[i]);
            }

            List<int> longestSubsequence = new List<int>();
            List<int> currentSubsequence = new List<int>();

            currentSubsequence.Add(parsedNums[0]);

            for (int i = 1; i < parsedNums.Length; i++)
            {
                if (parsedNums[i] == currentSubsequence[0])
                {
                    currentSubsequence.Add(parsedNums[i]);
                }
                else 
                {
                    if (currentSubsequence.Count > longestSubsequence.Count)
                    {
                        longestSubsequence = new List<int>();

                        for (int j = 0; j < currentSubsequence.Count; j++)
                        {
                            longestSubsequence.Add(currentSubsequence[j]);
                        }
                        
                    }

                    currentSubsequence = new List<int>();
                    currentSubsequence.Add(parsedNums[i]);
                }
            }

            if (currentSubsequence.Count > longestSubsequence.Count)
            {
                longestSubsequence = new List<int>();

                for (int j = 0; j < currentSubsequence.Count; j++)
                {
                    longestSubsequence.Add(currentSubsequence[j]);
                }

            }

            Console.WriteLine(string.Join(" ", longestSubsequence ));
        }
    }
}
