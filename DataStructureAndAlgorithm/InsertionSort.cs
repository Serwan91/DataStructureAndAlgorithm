using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    class InsertionSort
    {
        public static void SortNumbers()
        {
            int sortedIndex = 0;
            long[] testArr = SampleData.GetSampleNumbersData(20);
            Console.WriteLine("Before sort..");
            Utility.DumpArray<long>(testArr);

            
            while (sortedIndex < testArr.Length)
            {
                int lowestIndex = -1;
                for (int i = sortedIndex+1; i < testArr.Length ; i++)
                {
                    if (testArr[i] < testArr[sortedIndex])
                        lowestIndex = i;
                }

                if (lowestIndex != -1)
                {
                    testArr[sortedIndex] = testArr[sortedIndex] + testArr[lowestIndex];
                    testArr[lowestIndex] = testArr[sortedIndex] - testArr[lowestIndex];
                    testArr[sortedIndex] = testArr[sortedIndex] - testArr[lowestIndex];
                }
                   
                sortedIndex += 1;
            }

            Console.WriteLine("After sort..");
            Utility.DumpArray<long>(testArr);


        }
    }
}
