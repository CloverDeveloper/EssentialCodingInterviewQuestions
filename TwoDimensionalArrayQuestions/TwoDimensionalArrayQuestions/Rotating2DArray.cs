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

        public int[,] RotatingInPlace(int[,] originArray)
        {
            var level = originArray.GetLength(0);

            // row
            var ceiling = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(level) / 2));

            // col
            var floor = Convert.ToInt32(Math.Floor(Convert.ToDecimal(level) / 2));

            int indexA = 0;
            int indexB = 0;
            int[] temp = new int[4];
            for (int row = 0; row < ceiling; row += 1) 
            {
                for(int col = 0; col < floor; col += 1) 
                {
                    // 重置站存陣列，存放轉移值
                    temp = new int[4] { -1, -1, -1, -1 };

                    indexA = row;
                    indexB = col;

                    // 將舊值存起來
                    for(int i = 0; i < 4; i += 1) 
                    {
                        temp[i] = originArray[indexA, indexB];
                        var newPosition = this.GetNewPosition(indexA, indexB,level);
                        indexA = newPosition[0];
                        indexB = newPosition[1];
                    }

                    // 將暫存值回填到對應位置
                    for (int i = 0; i < 4; i += 1)
                    {
                        originArray[indexA, indexB] = temp[(i + 3) % 4];
                        var newPosition = this.GetNewPosition(indexA, indexB, level);
                        indexA = newPosition[0];
                        indexB = newPosition[1];
                    }

                }
            }

            return originArray;
        }

        /// <summary>
        /// 公式
        /// 新 row = 舊 col
        /// 新 col = 陣列長 - 1 - 舊 row
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        private int[] GetNewPosition(int row,int col,int level) 
        {
            return new int[] { col, level - 1 - row };
        }
    }
}
