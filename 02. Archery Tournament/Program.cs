using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main()
        {
            List<int> targets = Console.ReadLine().Split("|").Select(int.Parse).ToList();
            int points = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Game over" || input == "Game Over")
                {
                    break;
                }

                string[] command = input.Split().ToArray();
                if (command[0] == "Shoot")
                {
                    string[] info = command[1].Split("@").ToArray();
                    string direction = info[0];
                    int startIndex = int.Parse(info[1]);
                    int lenght = int.Parse(info[2]);
                    int currPoints = 0;

                    if (direction == "Left")
                    {
                        if (startIndex >= 0 && startIndex < targets.Count)
                        {
                            int targetIndex = startIndex - lenght;

                            if (targetIndex < 0)
                            {
                                targetIndex = targets.Count - Math.Abs(targetIndex % targets.Count);
                            }
                            if (targets[targetIndex] > 5)
                            {
                                targets[targetIndex] -= 5;
                                currPoints = 5;
                            }
                            else
                            {
                                currPoints = targets[targetIndex];
                                targets[targetIndex] = 0;
                            }
                        }
                    }
                    else if (direction == "Right")
                    {
                        if (startIndex >= 0 && startIndex < targets.Count)
                        {
                            int targetIndex = startIndex + lenght;

                            if (targetIndex > targets.Count - 1)
                            {
                                targetIndex = targetIndex % targets.Count;
                            }
                            if (targets[targetIndex] > 5)
                            {
                                targets[targetIndex] -= 5;
                                currPoints = 5;
                            }
                            else
                            {
                                currPoints = targets[targetIndex];
                                targets[targetIndex] = 0;
                            }
                        }
                    }
                    points += currPoints;
                }
                else if (command[0] == "Reverse")
                {
                   targets.Reverse();
                }
            }

            Console.WriteLine(string.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
