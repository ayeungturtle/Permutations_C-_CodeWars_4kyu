using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = new string[4];
            testArray = Permutations("1234");
            for (int i = 0; i < testArray.Count(); i++)
            {
                Console.WriteLine(testArray[i]);
            }
            Console.ReadLine();
        }

        static string[] Permutations(string input)
        {
            if (input.Length == 1)
            {
                string[] return1 = new string[1];
                return1[0] = input;
                return return1;
            }
            List<string> runningPermutationList = new List<string>();
            List<string> tempPermutationList = new List<string>();
            string starter1 = input[0].ToString() + input[1].ToString();
            string starter2 = input[1].ToString() + input[0].ToString();
            runningPermutationList.Add(starter1);
            runningPermutationList.Add(starter2);
            int nextInsertIndex = 2;

            while (nextInsertIndex < input.Length)
            {
                for (int i = 0; i < runningPermutationList.Count(); i++)
                {
                    for (int j = 0; j <= runningPermutationList[i].Length; j++)
                    {
                        string comboToAdd = runningPermutationList[i].Insert(j, input[nextInsertIndex].ToString());
                        tempPermutationList.Add(comboToAdd);
                    }
                }
                runningPermutationList.Clear();
                for (int k = 0; k < tempPermutationList.Count(); k++)   //fills in runningPermutationList with all the temp values
                {
                    string stringToAdd = tempPermutationList[k];
                    runningPermutationList.Add(stringToAdd);
                }
                tempPermutationList.Clear();
                nextInsertIndex++;
            }
                string[] permutationArray = new string[runningPermutationList.Count()];  //tested and confirmed functionality of change from list to array
                permutationArray = runningPermutationList.ToArray();
                return permutationArray;
        }
    }
}
