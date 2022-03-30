using System;

namespace TwoDimensionalArrayQuestions
{
    /// <summary>
    /// 踩地雷遊戲
    /// </summary>
    public class AssignNumbersInMinesweeper
    {
        /// <summary>
        /// 取的踩地雷地圖，炸彈設為 -1，附近區塊設為對應炸彈數
        /// 炸彈為 {{0, 2}, {2, 0}};
        /// mineSweeper(bombs1, 3, 3) should return:
        /// [
        ///     [0, 1, -1],
        ///     [1, 2, 1],
        ///     [-1, 1, 0]
        /// ]
        /// </summary>
        /// <param name="booms">炸彈位置</param>
        /// <param name="numRows">陣列 row 數</param>
        /// <param name="numCols">陣列 col 數</param>
        /// <returns></returns>
        public int[,] GetMinesweeperMap(int[,] booms, int numRows, int numCols) 
        {
            var res = new int[numRows, numCols];
            int boomIndexA = 0;
            int boomIndexB = 0;
            for (int row = 0; row < booms.GetLength(0); row += 1) 
            {
                boomIndexA = booms[row, 0];
                boomIndexB = booms[row, 1];

                // 設定炸彈位置為 -1
                res[boomIndexA, boomIndexB] = -1;

                // 設定炸彈旗數字，炸彈 9 宮格
                for(int i = boomIndexA - 1; i <= boomIndexA + 1; i += 1) 
                {
                    // 超出陣列範圍就結束
                    if (i < 0 || i >= res.GetLength(0)) continue;

                    for(int j = boomIndexB-1;j <= boomIndexB + 1; j += 1) 
                    {
                        // 超出陣列範圍、炸彈位置、當前炸彈位置、就結束
                        if (
                            j < 0 || 
                            j >= res.GetLength(1) || 
                            res[i, j] == -1 ||
                            boomIndexA == i && boomIndexB == j
                            ) continue;

                        res[i, j] += 1;
                    }
                }
            }

            return res;
        }
    }
}
