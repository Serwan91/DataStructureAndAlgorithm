using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    static class BinarySearch
    {
        static List<string> builder = new List<string>();
        public static void FindFirstOccurence(string searchvalue)
        {
            // Sample Data: 
            builder.Add("golu"); builder.Add("kolu"); builder.Add("nolu"); builder.Add("bolu");
            builder.Add("molu"); builder.Add("polu"); builder.Add("oolu"); builder.Add("bolu");
            builder.Add("chlu"); builder.Add("jolu"); builder.Add("rolu"); builder.Add("aolu");
            builder.Add("dolu"); builder.Add("iolu"); builder.Add("rolu"); builder.Add("bolu");
            string[] testArray = builder.ToArray();
            //string[] testArray = Utility.LoadCSVFile();
            Array.Sort(testArray);
            foreach (var item in testArray)
            {
                Console.WriteLine(item);
            }
            while (true)
            {
                long l, h, M, ctr;
                ctr = 0;
                l = 0;
                h = testArray.Length - 1;
                long CandidateIndex = -1;
                while (l <= h)
                {

                    M = l + ((h - l) / 2);
                    Console.Write(M);
                    Console.Write("\t");
                    if (testArray[M].ToLower().Trim() == searchvalue.ToLower().Trim())
                        CandidateIndex = M;

                    
                    if (String.Compare(testArray[M].ToLower().Trim(), searchvalue.ToLower().Trim()) == -1)
                        l = M + 1;
                    else
                        h = M - 1;

                    ctr = ctr+ 1;
                }
                Console.WriteLine("First Math Found at Index: {0}. No of Search Iteration took for this {1}", CandidateIndex,ctr);

                searchvalue = Console.ReadLine();
                if (Console.ReadLine() == "N")
                    break;
            }
        }

        public static void FindLastOccurence(string seachvalue)
        {
            // Sample Data: 
            builder.Add("golu"); builder.Add("kolu"); builder.Add("nolu"); builder.Add("bolu");
            builder.Add("molu"); builder.Add("polu"); builder.Add("oolu"); builder.Add("folu");
            builder.Add("chlu"); builder.Add("jolu"); builder.Add("rolu"); builder.Add("aolu");
            builder.Add("dolu"); builder.Add("iolu"); builder.Add("rolu"); builder.Add("bolu");
            string[] testArray = builder.ToArray();
            Array.Sort(testArray);
            foreach (var item in testArray)
            {
                Console.WriteLine(item);
            }
            int l, h, M;
            l = 0;
            h = testArray.Length -1;
            int candidateindex = -1;

            while(h >= l)
            {
                M = l + (h - l / 2);

                if (seachvalue == testArray[M])
                    candidateindex = M;

                if(String.Compare(seachvalue,testArray[M]) > -1 )
                {
                    l = M + 1;
                }
                else
                {
                    h = M - 1;
                }
            }
            Console.WriteLine("Found Last Match at index {0}",candidateindex);
        }

        public static void FindTotalOccurence(string searchvalue)
        {
            // Sample Data: 
            builder.Add("golu"); builder.Add("kolu"); builder.Add("nolu"); builder.Add("bolu");
            builder.Add("molu"); builder.Add("polu"); builder.Add("oolu"); builder.Add("bolu");
            builder.Add("chlu"); builder.Add("jolu"); builder.Add("rolu"); builder.Add("aolu");
            builder.Add("dolu"); builder.Add("iolu"); builder.Add("rolu"); builder.Add("bolu");
            string[] testArray = builder.ToArray();
            //string[] testArray = Utility.LoadCSVFile();
            Array.Sort(testArray);
            foreach (var item in testArray)
            {
                Console.WriteLine(item);
            }
            while (true)
            {
                int  ctr;
                ctr = 0;
                
                long FirstCandidateIndex = 0;
                long LastCandidateIndex = 0;

                    FirstCandidateIndex = GetFirstOccurence(testArray,  searchvalue);
                    LastCandidateIndex = GetLastOccurence(testArray, searchvalue);

                Console.WriteLine("Total Match Found: {0}. No of Search Iteration took for this {1}", 
                    (LastCandidateIndex == -1 ? 0 : (LastCandidateIndex-FirstCandidateIndex)+1), ctr);

                searchvalue = Console.ReadLine();
                if (Console.ReadLine() == "N")
                    break;
            }
        }

        private static long GetLastOccurence(string[] sampledate, string searchvalue)
        {
            long l, h, M, ctr;
            ctr = 0;
            l = 0;
            h = sampledate.Length - 1;
            long CandidateIndex = -1;
            while (l <= h)
            {

                M = l + ((h - l) / 2);
                //Console.Write(M);
                //Console.Write("\t");
                if (sampledate[M].ToLower().Trim() == searchvalue.ToLower().Trim())
                    CandidateIndex = M;


                if (String.Compare(sampledate[M].ToLower().Trim(), searchvalue.ToLower().Trim()) <= 0)
                    l = M + 1;
                else
                    h = M - 1;

                ctr = ctr + 1;
            }
            return CandidateIndex;

        }

        private static long GetFirstOccurence(string[] sampledate, string searchvalue)
        {
                long l, h, M, ctr;
                ctr = 0;
                l = 0;
                h = sampledate.Length - 1;
                long CandidateIndex = -1;
                while (l <= h)
                {

                    M = l + ((h - l) / 2);
                    //Console.Write(M);
                    //Console.Write("\t");
                    if (sampledate[M].ToLower().Trim() == searchvalue.ToLower().Trim())
                        CandidateIndex = M;


                    if (String.Compare(sampledate[M].ToLower().Trim(), searchvalue.ToLower().Trim()) == -1)
                        l = M + 1;
                    else
                        h = M - 1;

                    ctr = ctr + 1;
                }
            return CandidateIndex;

            }

        public static void  FindCountofUnqiueWords()
        {
            Console.WriteLine("Starting.. ");
            // Sample Data: 
            builder.Add("golu"); builder.Add("kolu"); builder.Add("nolu"); builder.Add("bolu");
            builder.Add("molu"); builder.Add("polu"); builder.Add("oolu"); builder.Add("bolu");
            builder.Add("chlu"); builder.Add("jolu"); builder.Add("rolu"); builder.Add("aolu");
            builder.Add("dolu"); builder.Add("iolu"); builder.Add("rolu"); builder.Add("bolu");
            string[] SampleData = builder.ToArray();
            //string[] SampleData = Utility.LoadCSVFile();
            HashSet<UnqiueSet> hashset = new HashSet<UnqiueSet>();
            Array.Sort(SampleData);
            int l, h, m;
            l = 0;
            h = SampleData.Length - 1;
            if (SampleData[l] == SampleData[h])
            {
                UnqiueSet item = new UnqiueSet() { word = SampleData[l], count = SampleData.Length };
                if (!hashset.Contains(item))
                {
                    hashset.Add(item);
                }

                for (int i = 0; i < hashset.Count; i++)
                {
                    Console.WriteLine(hashset.ElementAtOrDefault(i).word +" - "+ hashset.ElementAtOrDefault(i).count);
                }
                return;
            }
            else
            {
                while (l <= h)
                {
                    m = l + ((h - l) / 2);
                    int x = l;
                    int f = GetOccurenceIndex(SampleData, l, m, x, true);
                    int L = GetOccurenceIndex(SampleData, l, m+1,x, false);

                    hashset.Add(new UnqiueSet { word = SampleData[L], count = (L - f) + 1 });
                    l = L+1;
                }
            }

            foreach (var item in hashset)
            {
                Console.WriteLine(String.Format("Word : {0} - Count: {1}", item.word, item.count));
            }
        }

        private static int GetOccurenceIndex(string[] sampleData, int l, int m, int x, bool firstOccurance)
        {
            int CIndex = -1;
            if(sampleData[x] == sampleData[m])
            {
                if (firstOccurance)
                    CIndex = x;
                if(!firstOccurance)
                    CIndex = m;

                return CIndex;
            }
            else if (String.Compare(sampleData[x],sampleData[m]) < 0)
            {
              return  GetOccurenceIndex(sampleData, l, m - 1, x, firstOccurance);
            }
            else
            {
               return GetOccurenceIndex(sampleData, l+1, m, x, firstOccurance);
            }
            //return CIndex;
        }

        class UnqiueSet
        {
            public string word { get; set; }
            public int count { get; set; }
        }
    }
}
