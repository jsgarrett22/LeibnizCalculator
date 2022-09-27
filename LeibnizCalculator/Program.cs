using System;

/** Leibniz Formula - Leibniz Formula Example
 * Calculates the value of pi based on the user's input, which specifices the number of
 * iterations being done on the pi value using the Leibniz formula. The more iterations,
 * the more precise the pi value.
 * Written by Joshua S. Garrett
 * 09/27/2022
 */
namespace LeibnizCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double summation = 0;
            double pi = 0;
            int userCount = 0;
            bool validate = false;

            Console.WriteLine("Joshua's Implementation of the Leibniz Formula:\n");

            Console.WriteLine("Please enter the number of times to run this calculation");

            // START
            while (!validate)
            {
                try
                {
                    Console.Write("Please enter value > 1 million: ");
                    userCount = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                }

                if (userCount <= 1000000)
                {
                    continue;
                }
                else
                {
                    validate = true;

                    Console.WriteLine("\n----------\n");

                    for (int iteration = 0; iteration <= userCount; iteration++)
                    {
                        switch (iteration)
                        {
                            case 10:
                                Console.WriteLine($"At iteration {iteration:n0}, the value of pi is {pi:n10}");
                                break;
                            case 1000:
                                Console.WriteLine($"At iteration {iteration:n0}, the value of pi is {pi:n10}");
                                break;
                            case 100000:
                                Console.WriteLine($"At iteration {iteration:n0}, the value of pi is {pi:n10}");
                                break;
                            case 500000:
                                Console.WriteLine($"At iteration {iteration:n0}, the value of pi is  {pi:n10}");
                                break;
                            case 1000000:
                                Console.WriteLine($"At iteration {iteration:n0}, the value of pi is  {pi:n10}");
                                break;
                            case 2000000:
                                Console.WriteLine($"At iteration {iteration:n0}, the value of pi is  {pi:n10}");
                                break;
                            default:
                                break;
                        }
                        summation += (Math.Pow(-1, iteration)) / (2 * iteration + 1);
                        pi = 4 * summation;
                    }
                    // HANG CONSOLE
                    Console.WriteLine("\nPress the ENTER key to end this program . . .");
                    Console.ReadLine();
                }
            }
        }
    }
}
