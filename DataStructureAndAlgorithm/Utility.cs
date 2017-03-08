using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    static class Utility
    {
        public static string[] LoadCSVFile()
        {
            string[] rows = { };
            StreamReader reader = new StreamReader(@"D:\GitProjects\DataStructureAndAlgorithm\SampleSingleDimentionalData.csv");
            while (!reader.EndOfStream)
            {
                string sampledata  = reader.ReadToEnd();
                rows = sampledata.Split('\r');
                
            }
            return rows;
        }
    }
}
