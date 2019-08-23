using System;
using System.Linq;

namespace RoshniShah_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string iput = Console.ReadLine();

            var ifInt = iput.All(char.IsDigit);

            if (ifInt)
            {
                int a = Convert.ToInt32(iput);
                Console.WriteLine("Output: {0}", a);
            }
            else
            {
                for (int x = 0; x < iput.Length; x++)
                {

                    int endIndex = iput.IndexOf(')');
                    int startIndex = 0;
                    for (int i = 0; i < endIndex; i++)
                    {
                        int index = iput.IndexOf('(', i);
                        if (index > 0 && index < endIndex)
                        {
                            startIndex = index;
                        }
                    }
                    int charReq = endIndex - startIndex;
                    string step = iput.Substring(startIndex, charReq + 1);
                    string reqStep = step.Trim('(').Trim(')');
                    //Console.WriteLine(reqStep);

                    string[] ssize = reqStep.Split(" ");
                    int result = 0;
                    try
                    {
                        if (ssize[0] == "add" || ssize[0] == "Add" || ssize[0] == "ADD")
                        {
                            result = Convert.ToInt32(ssize[1]) + Convert.ToInt32(ssize[2]);
                        }
                        else if (ssize[0] == "multiple" || ssize[0] == "Multiple" || ssize[0] == "MULTIPLE")
                        {
                            result = Convert.ToInt32(ssize[1]) * Convert.ToInt32(ssize[2]);
                        }


                        Console.WriteLine(step + " = " + result);

                        iput = iput.Trim().Replace(step, result.ToString());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Sorry Error !!!");
                    }
                }

                int a = Convert.ToInt32(iput);
                Console.WriteLine("Output: {0}", a);

            }
            Console.ReadKey();
        }
    }
}
