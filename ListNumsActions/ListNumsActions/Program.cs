using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins":
                        nums.Insert(int.Parse(cmd[1]), int.Parse(cmd[2]));
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                        break;

                        break;
                    case "del":
                        nums.Remove(int.Parse(cmd[1]));
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                        break;
                        break;
                    case "contains":
                        int targetElement = nums[1];

                        if (nums.Contains(targetElement))
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                        break;
                        break;
                        break;
                    case "remove":
                        //TODO`
                        break;
                   
                    case "countl":
                        int number = int.Parse(cmd[1]);
                        int count = nums.Count(x => x > number);
                        Console.WriteLine(count);
                        break;

                    case "cut":
                        int n = int.Parse(cmd[1]);

                        if (n >= nums.Count)
                        {
                            nums.Clear();
                        }
                        else
                        {
                            nums.RemoveRange(0, n);
                        }
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
