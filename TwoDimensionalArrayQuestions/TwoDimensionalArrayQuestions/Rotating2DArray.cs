using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArrayQuestions
{
    /// <summary>
    /// 旋轉 2 維陣列(90 度)
    /// </summary>
    public class Rotating2DArray
    {
        public int[,] Rotating(int[,] originArray) 
        {
            var res = new int[originArray.GetLength(0), originArray.GetLength(1)];

            // 公式
            // 新 i = 舊 j
            // 新 j = 陣列長 - 1 - 舊 i
            for(int i =0;i< originArray.GetLength(0); i += 1) 
            {
                for(int j = 0; j < originArray.GetLength(1); j += 1) 
                {
                    res[j, originArray.GetLength(1) - 1 -i] = originArray[i,j];
                }
            }

            return res;
        }
    }
}
