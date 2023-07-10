using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas;

public class MeanSquareError
{
    public static double Solution(int[] firstArray, int[] secondArray)
    {
        double sum = 0;
        for (int i = 0; i < firstArray.Length; i++)
        {
            int difference = Math.Abs(firstArray[i] - secondArray[i]);
            sum += difference * difference;
        }
        return sum / secondArray.Length;

    }
}
