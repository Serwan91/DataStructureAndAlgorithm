using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    /// <summary>
    /// Big O notation is used in Computer Science to describe the performance or complexity of an algorithm. 
    /// Big O specifically describes the worst-case scenario, and can be used to describe the execution time 
    /// required or the space used (e.g. in memory or on disk) by an algorithm
    /// </summary>
    static class BigONotationDemo
    {
        // O(1) -- signify absolute time: No matter the size of data, time remain constant
        // O(n) -- signify linear increase in time: As the data size grow, time also increase along.
        // O(n^2) -- represents an algorithm whose performance is directly proportional to the square power
        //of the size of the input data set. This is common with algorithms that involve nested iterations over the data set. Deeper nested iterations will result in O(N3), O(N4) etc.
        static long[] SampleData;
        static BigONotationDemo()
        {
        }
        public static void PrintConcept()
        {
            Console.WriteLine("1. O(1) : \n signify absolute time: No matter the size of data, time remain constant ");
            Console.WriteLine("2. O(N) : \n signify linear increase in time: As the data size grow, time also increase along. ");
            Console.WriteLine("3. O(N^2) : \n represents an algorithm whose performance is directly proportional to the square"+
                  "of the size of the input data set. This is common with algorithms that involve nested iterations over the data set."+
                  "Deeper nested iterations will result in O(N3), O(N4) etc. ");
            Console.WriteLine("4. O(2^N) : \n enotes an algorithm whose growth/time doubles with each additon to the input data set. The growth curve of an O(2N) function is exponential ");
            Console.WriteLine("5. O(N Log N) : \n enotes an algorithm whose growth/time get halve with each increase size (N^10) of input data. Binary Search algorithim represent this notation ");

        }

        public static void ShowBigODemo(long[] arr)
        {
            SampleData = arr;
            while (true)
            {
                Console.WriteLine("Enter the Number to display the Big O demo");
                int num = Convert.ToInt16(Console.ReadLine());
               
                if (num < 1 || num > 5)
                {
                    Console.WriteLine("Invalid Number Selection.Enter in range 1-5");
                    continue;
                }

                switch (num)
                {
                    case 1:
                        BigOAbsoluteDemo();
                        break;
                    case 2:
                        BigOLinearGrowthDemo();
                        break;

                    case 3:
                        BigOPropotionaltoPowerGrowth();
                        break;

                    case 4:
                        BigOPropotionalDoubleGrowth();
                        break;

                    case 5:
                        BigONLogNGrowth();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Do you want to continue with Same Sample Data? Y/N ");
                if (Console.ReadLine().ToUpper() == "N")
                    break;
            }
        }

        private static void BigONLogNGrowth()
        {
            Console.WriteLine("Please Enter the value to search in the data array");
            int searchvalue = Convert.ToInt32(Console.ReadLine());
            // BinarySearch is O(N Log N)
            Console.WriteLine("O(N Log N): demo");
            long StartTime, Endtime;
            int l, h,m;
            l = 0;
            h = SampleData.Length;
            Console.WriteLine("input data :");
            for (int i = 0; i < SampleData.Length; i++)
            {
               // Console.Write(SampleData[i].ToString() + ",");
            }
            Console.WriteLine("");

            StartTime = DateTime.Now.Millisecond;
            while (l <= h)
            {
                m =  l +((h -l) / 2);
                Console.WriteLine("M value {0}, H value {1}, L value {2}, equation Value {3}",m,h,l, (h - l) / 2);

                if(SampleData[m] == searchvalue)
                {
                    Console.WriteLine("Match Found {0}", SampleData[m]);
                    break;
                }
                // checks if the searched value is less than (left-side) or greater-than (right-side)
                if (searchvalue < SampleData[m])
                    h = m - 1;
                else
                    l = m + 1;
            }
            
            Endtime = DateTime.Now.Millisecond;
            Console.WriteLine("Time Taken in MilliSeconds :{0}", (Endtime - StartTime));
        }

        private static void BigOPropotionalDoubleGrowth()
        {
            Console.WriteLine("Please Enter the value to search in the data array");
            int searchvalue = Convert.ToInt32(Console.ReadLine());
            
        }

        private static void BigOPropotionaltoPowerGrowth()
        {
            long value;
            IDictionary<long, long> duplicatesList = new Dictionary<long, long>();
            TimeSpan StartTime, Endtime;
            StartTime = DateTime.Now.TimeOfDay;
            // checks duplicates and get all count
            for (int i = 0; i < SampleData.Length; i++)
            {
                for (int j = 0; j < SampleData.Length; j++)
                {
                    if (i == j) continue; // skip slef comparision

                    if(SampleData[i] == SampleData[j])
                    {
                        //if (duplicatesList.ContainsKey(SampleData[i]))
                        if(duplicatesList.TryGetValue(SampleData[i], out value))
                            duplicatesList[SampleData[i]] = value + 1;
                        else
                            duplicatesList.Add(SampleData[i], 1);
                    }
                }
            }
            Endtime = DateTime.Now.TimeOfDay;
            Console.WriteLine("Time Taken in MilliSeconds :{0}", (Endtime - StartTime));
            Console.WriteLine("Total Duplicates Elements count {0}",duplicatesList.Count);
            //foreach (var item in duplicatesList)
            //{
            //    Console.WriteLine(item.Key.ToString() +" : " + item.Value.ToString());
            //}
        }

        private static void BigOLinearGrowthDemo()
        {

            Console.WriteLine("Please Enter the value to search in the data array");
            int searchvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Big O linear growth remains same: demo");
            long StartTime, Endtime;
            bool matchfound = false;
            StartTime = DateTime.Now.Millisecond;
            for (int i = 0; i < SampleData.Length; i++)
            {
                if (SampleData[i] == searchvalue)
                {
                    Console.WriteLine("Match found at index {0} with value {1}",i,SampleData[i]);
                    matchfound = true;
                    break;
                }
            }
            if (!matchfound)
                Console.WriteLine("Match Not found for value : {0}", searchvalue);
            Endtime = DateTime.Now.Millisecond;
            Console.WriteLine("Time Taken in MilliSeconds :{0}", (Endtime - StartTime));
        }

        private static void BigOAbsoluteDemo()
        {
            Console.WriteLine("Big O absolute growth remains same: demo");
            long StartTime, Endtime;
            StartTime = DateTime.Now.Millisecond;
                SampleData[0] = -1;
            Endtime = DateTime.Now.Millisecond;
            Console.WriteLine("Time Taken in MilliSeconds :{0}", (Endtime - StartTime));
            
        }
    }
}
