using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    class BubbleSort
    {
        public static void SortStrings()
        {
            string[] testArr = SampleData.GetSampleData();
            Console.WriteLine("Before Sorting..");
            Utility.DumpArray<string>(testArr);
            int h = testArr.Length - 1;
            string swapval = "";
            for (int i = 0; i < testArr.Length; i++)
            {
                for (int j = i+1 ; j < testArr.Length ; j++)
                {
                    if (String.Compare(testArr[i],testArr[j]) > 0)
                    {
                        swapval = testArr[i];
                        testArr[i] = testArr[j];
                        testArr[j] = swapval;
                    }
                }

            }
            Console.WriteLine("After Sorting..");
            Utility.DumpArray<string>(testArr);
        }

        internal static void BubbleSortNumbers()
        {
            long[] testArr = SampleData.GetSampleNumbersData(20);
            Console.WriteLine("Before Sorting..");
            Utility.DumpArray<long>(testArr);

            for (int i = 0; i < testArr.Length; i++)
            {
                for (int j = i+1; j < testArr.Length; j++)
                {
                    if(testArr[i] > testArr[j])
                    {

                        // swap without third variable: i =  10, j =5 
                        testArr[i] = testArr[j] + testArr[i];
                        testArr[j] = testArr[i]  - testArr[j] ;
                        testArr[i] = testArr[i] - testArr[j];
                    }
                }
            }
            Console.WriteLine("After Sorting..");
            Utility.DumpArray<long>(testArr);
        }
    }
}
