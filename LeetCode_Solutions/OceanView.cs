using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class OceanView
    {
        public static int FindOceanViewBuildings(int[] buildings)
        {
            int count = 0;
            if(buildings.Length > 0)
            {
                count++;
            }
                
            for (int i = buildings.Length - 1; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (buildings[i] <= buildings[j])
                    {
                        break;
                    }
                    if (j == 0)
                    {
                        if(buildings[i] > buildings[j])
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
