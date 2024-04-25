using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    public class RemoveElements
    {
        public static int[] Remove(int[] elements, int[] remove) 
        {
            List<int> result = new List<int>();                        
            
            foreach (int element in elements)
            {                    
                if ( !remove.Contains(element))
                {
                    result.Add(element);
                }                    
            }
          
            return result.ToArray();            
        }
    }
}
