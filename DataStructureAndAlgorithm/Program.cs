using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = "y";
            do
            {
                Console.WriteLine("Please Enter the new size for the data array");
                long[] DataArr = GetSampleData(Convert.ToInt64(Console.ReadLine()));
                Array.Sort<long>(DataArr); 

                //BigONotationDemo.PrintConcept();
                BigONotationDemo.ShowBigODemo(DataArr);

                Console.WriteLine("Key-in 'N' to exit program. Else continue with new sample data");
                res = Console.ReadLine().ToString();
            } while (res.ToUpper()  != "N");

            Console.ReadLine();
        }

        private static long[] GetSampleData(long arraysize)
        {
            long[] DataArr;
            Random random = new Random();
            // Sample Data : 
            DataArr = new long[arraysize];
            //initialize Array
            for (int i = 0; i < DataArr.Length; i++)
            {
                DataArr[i] = random.Next(1, DataArr.Length);
                //Console.WriteLine(DataArr[i] +" ,");
            }

            return DataArr;
        }
    }
}
