using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    /// <summary>
    /// 取得 Array 中最常出現項目 O(n)
    /// </summary>
    public class MostFrequentlyOccurringItem
    {
        /// <summary>
        /// 取得最常出現的項目
        /// </summary>
        /// <param name="array">輸入陣列</param>
        /// <returns></returns>
        public int? GetFrequentlyOccurringItem(int[] array) 
        {
            // 陣列若為 null 或空陣列回傳 null
            if (array == null || array.Length == 0) return null;

            // 當前出現最多次的數字
            int item = 0;

            // 出現最多次的數字次數
            int maxCount = 0;

            // 暫存字典存放對應數字(Key)與次數
            Dictionary<int,int> tempDic = new Dictionary<int,int>();
            for (int i = 0; i < array.Length; i++) 
            {
                // 若 key 不存在就寫入，並設定次數為 1
                if (!tempDic.ContainsKey(array[i])) 
                {
                    tempDic.Add(array[i], 1);

                    continue;
                }

                // 若 key 存在次數 +1，並判斷次數是法大於暫存的最大次數，若大於就更新
                tempDic[array[i]] += 1;
                if(tempDic[array[i]] > maxCount) 
                {
                    maxCount = tempDic[array[i]];
                    item = array[i];
                }
            }

            return item;
        }
    }
}
