using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    class SampleData
    {
        static string[] builder = new string[16];
        public static string[] GetSampleData()
        {
            builder[0] = "golu"; builder[4] = "kolu"; builder[8] = "nolu"; builder[12] = "bolu";
            builder[1] = "molu"; builder[5] = "polu"; builder[9] = "oolu"; builder[13] = "bolu";
            builder[2] = "chlu"; builder[6] = "jolu"; builder[10] = "rolu"; builder[14] = "aolu";
            builder[3] = "dolu"; builder[7] = "iolu"; builder[11] = "rolu"; builder[15] = "bolu";
                                                                         
            return builder;
        }

        public static long[] GetSampleNumbersData(long arraysize)
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
