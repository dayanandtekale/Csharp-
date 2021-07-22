using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemos
{
    class trycatchdemo
    {
        static void Main()
        {
            int num1, num2;
            int[] scores = new int[5] { 12, 45, 67, 89, 20 };
            try
            {
                Console.WriteLine("Enter the first number");
                num1 = System.Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second number");
                num2 = System.Convert.ToInt32(Console.ReadLine());
                int ans = num1 + num2;
                Console.WriteLine($"The addition of {num1} and {num2} is {ans}");

                for (int ctr = 0; ctr < scores.Length; ctr++)
                    Console.WriteLine($"The score is {scores[ctr]}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter numberic data");
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Cheack the for loop for the index of the array");
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown Error");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
            Console.WriteLine("Back to Normal Execution");
        }
    }
}
