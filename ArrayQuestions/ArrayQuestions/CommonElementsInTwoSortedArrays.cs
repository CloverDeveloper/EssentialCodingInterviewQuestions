using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    /// <summary>
    /// 取得 2 已排序陣列內共同項目
    /// </summary>
    public class CommonElementsInTwoSortedArrays
    {
        /// <summary>
        /// 取得共同項目
        /// </summary>
        /// <param name="arrayA">陣列 A</param>
        /// <param name="arrayB">陣列 B</param>
        /// <returns></returns>
        public int[] GetCommonArray(int[] arrayA,int[] arrayB) 
        {
            // 初始 index
            int indexA = 0;
            int indexB = 0;

            // 紀錄共同項目
            var res = new List<int>();

            // 當任一個陣列未執行完就繼續
            while (indexA < arrayA.Length && indexB < arrayB.Length) 
            {
                // 若值相同就新增紀錄，並一起移動 index
                if (arrayA[indexA] == arrayB[indexB]) 
                {
                    res.Add(arrayA[indexA]);
                    indexA += 1;
                    indexB += 1;

                    continue;
                }

                // 若大小不符，移動對應 index 
                if(arrayA[indexA] > arrayB[indexB]) 
                {
                    indexB += 1;
                }
                else 
                {
                    indexA += 1;
                }
            }

            return res.ToArray();
        }
    }
}
