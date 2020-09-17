using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please type in a string.");
  
            string Input = Console.ReadLine();
            long sum = 0;
            int startIndex = 0;
            int endIndex = 0;

                while (startIndex < Input.Length - 1)
                {
                    endIndex = startIndex + 1;

                    if (Char.IsDigit(Input[startIndex]) && Char.IsDigit(Input[endIndex]))
                    {
                        while (endIndex < Input.Length)
                        {
                            if (Input[endIndex].Equals(Input[startIndex]))
                            {
                                PrintMatch(startIndex, endIndex, Input);

                                long number = long.Parse(Input.Substring(startIndex, endIndex - startIndex + 1));
                                sum += number;

                                break;
                            }
                            else if (!Char.IsDigit(Input[endIndex]))
                            {
                                break;
                            }
                            endIndex += 1;
                        }
                    }
                    startIndex += 1;
                }
                Console.WriteLine("The total sum of your string is: " + sum);
            }
            static void PrintMatch(int startIndex, int endIndex, string Input)
            {
                for (int i = 0; i < Input.Length; i++)
                {
                    if (i > startIndex && i <= endIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    Console.Write(Input[i]);
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\n");
            }
        }
    }


            
