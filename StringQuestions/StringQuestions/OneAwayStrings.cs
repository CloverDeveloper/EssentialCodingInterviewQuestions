using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQuestions
{
    /// <summary>
    /// 檢查 2 字串是否差異 1 個字 O(n)
    /// s1 = abcde  = true
    /// s2 = abde = true
    /// 
    /// s1 = a = true
    /// s2 = a = true
    /// 
    /// s1 = abc = false
    /// s2 = cca = false
    /// </summary>
    public class OneAwayStrings
    {
        /// <summary>
        /// 檢查 2 字串是否差異 1 個字
        /// </summary>
        /// <returns></returns>
        public bool IsOneAwayStrings(string strA,string strB) 
        {
            return this.MyAns(strA, strB);
        }

        /// <summary>
        /// 自己解法
        /// </summary>
        /// <returns></returns>
        private bool MyAns(string strA, string strB) 
        {
            // 長度相減大於 1 為 false
            if (Math.Abs(strA.Length - strB.Length) > 1) return false;

            int indexA = 0;
            int indexB = 0;
            int count = 0;
            while (indexA < strA.Length && indexB < strB.Length)
            {
                if (strA[indexA] == strB[indexB])
                {
                    indexA += 1;
                    indexB += 1;

                    continue;
                }

                // 字元不同，且 2 字串長度相符，位置一起變動
                if (strA[indexA] != strB[indexB] && strA.Length == strB.Length)
                {
                    indexA += 1;
                    indexB += 1;
                    count += 1;
                }

                // 字元不同，且 A 字串長度 > B 字串長度，A 進行位移
                else if (strA[indexA] != strB[indexB] && strA.Length > strB.Length)
                {
                    indexA += 1;
                    count += 1;
                }

                // 字元不同，且 B 字串長度 > A 字串長度，B 進行位移
                else
                {
                    indexB += 1;
                    count += 1;
                }

                if (count > 1)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// 影片解法
        /// </summary>
        /// <returns></returns>
        private bool Video(string strA, string strB) 
        {
            if (strA.Length - strB.Length > 1 || strB.Length - strA.Length > 1)
                return false;

            if(strA.Length == strB.Length) 
            {
                return this.IsOneAwayStringsSameLength(strA, strB);
            }

            if(strA.Length > strB.Length) 
            {
                return this.IsOneAwayStringsDiffLength(strA, strB);
            }

            if (strB.Length > strA.Length)
            {
                return this.IsOneAwayStringsDiffLength(strB, strA);
            }

            return false;
        }

        /// <summary>
        /// 不相同長度處理方法
        /// </summary>
        /// <returns></returns>
        private bool IsOneAwayStringsDiffLength(string strA, string strB)
        {
            // strA 長度較長
            // strB 長度較短

            int index = 0;
            int countDiff = 0;

            while(index < strB.Length) 
            {
                // 判斷 strA 對應位置與 strB 對應位置 + 差異字數
                // strA = abde
                // strB = abcde
                if (strB[index] == strA[index + countDiff]) 
                {
                    index += 1;

                    continue;
                }

                if (strB[index] != strA[index + countDiff])
                {
                    countDiff += 1;
                }

                if (countDiff > 1)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// 相同長度處理方法
        /// </summary>
        /// <returns></returns>
        private bool IsOneAwayStringsSameLength(string strA, string strB)
        {
            int countDiff = 0;
            for(int i = 0; i < strA.Length; i += 1) 
            {
                if (strA[i] != strB[i])
                    countDiff += 1;

                if (countDiff > 1)
                    return false;
            }

            return true;
        }
    }
}
