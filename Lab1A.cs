using System;

namespace Lab1A
{
    class Program
    {
        static void Main(string[] args)

            {
                if (args.Length != 1)
                {
                    Console.WriteLine("Argument Error: this program expects one command line argument");
                    Environment.Exit(-1);
                }
                if (args[0].Length == 1)
                {
                    Console.WriteLine("Argument Error: this program expects the command line argument to be longer than 1 character");
                    Environment.Exit(-2);
                }

                string Input = args[0];
                long sum = 0;
                int startIndex = 0;
                int endIndex = 0;

                while (startIndex < args[0].Length - 1)
                {
                    endIndex = startIndex + 1;

                    if (Char.IsDigit(Input[startIndex]) && Char.IsDigit(Input[endIndex]))
                    {
                        while (endIndex < args[0].Length)
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
                Console.WriteLine("The total sum of your string is:  " + sum);
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


            

