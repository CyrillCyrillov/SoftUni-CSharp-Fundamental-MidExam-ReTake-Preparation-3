using System;
using System.Linq;
using System.Collections.Generic;

namespace Task03_Memory_game
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sequence = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            int actionCount = 0;
            bool isWinn = false;

            while (true)
            {
                string[] action = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(action[0].ToUpper() == "END")
                {
                    break;
                }

                actionCount++;

                int indexOne = int.Parse(action[0]);
                int indexTwo = int.Parse(action[1]);

                if (indexOne == indexTwo | indexOne < 0 | indexOne > sequence.Count - 1 | indexTwo < 0 | indexTwo > sequence.Count - 1)
                {
                    string stringToInsert = "-" + actionCount.ToString() + "a";
                    int indexToInsert = sequence.Count / 2;
                    sequence.Insert(indexToInsert, stringToInsert);
                    sequence.Insert(indexToInsert + 1, stringToInsert);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");

                }
                else if(sequence[indexOne] == sequence[indexTwo])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequence[indexOne]}!");
                    string helpVarToRemote = sequence[indexOne];
                    sequence.Remove(helpVarToRemote);
                    sequence.Remove(helpVarToRemote);

                    if (sequence.Count == 0)
                    {
                        isWinn = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }

            if (isWinn)
            {
                Console.WriteLine($"You have won in {actionCount} turns!");
            }
            else
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', sequence));
            }
        }
    }
}
