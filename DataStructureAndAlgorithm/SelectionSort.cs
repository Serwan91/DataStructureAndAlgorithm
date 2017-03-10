using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    class SelectionSort
    {
        public static void SelectionSortString()
        {
            string[] testArr = SampleData.GetSampleData();
            int sortIndex = 0;
            int h = testArr.Length - 1;
            string swapVal = "";
            while (sortIndex <= h)
            {
                for (int i = 0; i < testArr.Length; i++)
                {
                    if (String.Compare(testArr[i], testArr[sortIndex]) > 0)
                    {
                        swapVal = testArr[i];
                        testArr[i] = testArr[sortIndex];
                        testArr[sortIndex] = swapVal;
                    }
                }
                sortIndex += 1;
            }
            Utility.DumpArray<string>(testArr);
        }

        internal static void SelectionSortNumbers()
        {
            Console.WriteLine("Enter the array size to create");
            int size = Convert.ToInt32(Console.ReadLine());
            if(size > 0)
            {
               long[] testArr =  SampleData.GetSampleNumbersData(size);
                int h = testArr.Length - 1;
                int sortIndex = 0;
                long swapval = -1;
                while (sortIndex <= h)
                {
                    for (int i = 0; i < h; i++)
                    {
                        if(testArr[i] > testArr[sortIndex])
                        {
                            swapval = testArr[i];
                            testArr[i] = testArr[sortIndex];
                            testArr[sortIndex] = swapval;
                        }
                    }
                    sortIndex += 1;
                }

                Utility.DumpArray<long>(testArr);
            }
        }
    }
}
