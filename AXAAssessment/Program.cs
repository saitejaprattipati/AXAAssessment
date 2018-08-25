using System;
using System.Linq;
using System.Collections.Generic;

namespace AXAAssessment
{
   public class AXAAssesment
    {
        static void Main(string[] args)
        {
            AXAAssesment objProgram = new AXAAssesment();
            if (objProgram.printDigits(100))
                Console.WriteLine("Operation Completed \nPress any key to exit");
            else
                Console.WriteLine("Operation Failed \nPress any key to exit");
            Console.ReadKey();
           
        }
        public bool printDigits(int value)
        {
            try
            {
                List<int> digits = new List<int>();
                digits = Enumerable.Range(1, 100).ToList();
                for (int i = 1; i <= value; i++)
                {
                    Console.WriteLine(digits[i - 1]);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}
