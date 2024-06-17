using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    public class CountMostFrequentItem
    {
        public static int MostFrequentItem(int[] collection)
        {
            int count = 0;
            int finalCount = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                foreach (int item in collection)
                {
                    if (collection[i] == item) count++;
                }
                if (count > finalCount)
                {
                    finalCount = count;
                }
                count = 0;
            }            

            return finalCount;
        }
    }
}
