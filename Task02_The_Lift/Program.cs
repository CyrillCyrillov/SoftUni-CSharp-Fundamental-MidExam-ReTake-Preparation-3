    using System;
    using System.Linq;

    namespace Task02_The_Lift
    {
        class Program
        {
            static void Main(string[] args)
            {
                int peopleCount = int.Parse(Console.ReadLine());
                int startPeople = peopleCount;

                int[] liftState = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int startPeopleInLift = liftState.Sum();
             

                bool isUnchekedVagons = false;

                for (int i = 0; i <= liftState.Length - 1; i++)
                {
                    int freeSpace = 4 - liftState[i];
                    if(freeSpace > 0)
                    {
                        liftState[i] += freeSpace;
                        peopleCount -= freeSpace;

                        if(peopleCount < 0)
                        {
                            liftState[i] -= Math.Abs(peopleCount);
                            peopleCount = 0;
                        }
                    }

                    if(peopleCount == 0)
                    {
                        isUnchekedVagons = true;
                        break;
                    }
                }
            
                if(peopleCount > 0)
                {
                    Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!");
                }
                else if(isUnchekedVagons && liftState.Sum() < liftState.Length * 4)
                {
                    Console.WriteLine("The lift has empty spots!");
                }
            
                Console.WriteLine(string.Join(' ', liftState));
            }
        }
    }
