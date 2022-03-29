using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    /// <summary>
    /// 一個陣列是另一個陣列的旋轉嗎 O(n)
    /// </summary>
    public class IsOneArrayARotationOfAnother
    {
        /// <summary>
        /// 是否為旋轉
        /// </summary>
        /// <param name="arrayA">陣列 A</param>
        /// <param name="arrayB">陣列 B</param>
        /// <returns></returns>
        public bool IsRotation(int[] arrayA ,int[] arrayB) 
        {
            // 若陣列長度不同表示不為旋轉陣列
            if (arrayA.Length != arrayB.Length) return false;

            // 預設陣列 B 的初始 index = -1，取得陣列 A 第一個值與陣列 B 相同值的位置，若無表示不為旋轉陣列
            int indexB = -1;
            for (int i = 0; i < arrayB.Length; i++) 
            {
                if (arrayB[i] == arrayA[0])
                {
                    indexB = i;
                    break;
                }
            }

            if(indexB == -1) return false;

            for(int i = 0; i < arrayA.Length; i += 1) 
            {
                // 取得陣列 B 對應陣列 A 的 Index 位置
                // A[0] = 1
                // B[4] = 1
                // j = (4 + 0) % 7 = 4
                var j = (indexB + i) % arrayA.Length;

                // 若對應值不符表示不為旋轉陣列
                if (arrayA[i] != arrayB[j]) return false;
            }

            return true;
        }
    }
}
