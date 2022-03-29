using System;

namespace SortQuestions
{
    /// <summary>
    /// 氣泡排序法
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="array">待排序陣列</param>
        /// <returns></returns>
        public int[] Sort(int[] array) 
        {
            int temp;

            // 判斷是否有進行排序，若都沒有排序到就結束，表示排序完了
            bool isSorted = false;
            for(int i = 0; i < array.Length; i += 1) 
            {
                for (int j = 0; j < array.Length -1; j += 1) 
                {
                    if (array[j] > array[j + 1]) 
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;

                        isSorted = true;
                    }
                }

                if (!isSorted) break;

                isSorted = false;
            }

            return array;
        }
    }
}
