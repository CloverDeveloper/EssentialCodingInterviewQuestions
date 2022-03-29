using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortQuestions
{
    /// <summary>
    /// 快速排序法
    /// </summary>
    public class QuickSort
    {
        /// <summary>
        /// 排序方法
        /// </summary>
        /// <returns></returns>
        public int[] Sort(int[] array) 
        {
            this.Sort(array, 0, array.Length-1);

            return array;
        }

        private void Sort(int[] array,int left,int right) 
        {
            // 1. 如果左邊 index >= 右邊就結束
            if (left >= right) return;

            // 2. 取得中位數值 pivot
            var pivot = array[(left + right)/2];

            // 3. 進行排序，並取得最終 left index 位置
            var partition = this.Partition(array, left, right, pivot);

            // 4. 分割陣列重複執行排序法
            this.Sort(array, left, partition - 1);
            this.Sort(array, partition, right);
        }

        private int Partition(int[] array, int left, int right, int pivot)
        {
            // 當左邊位置小於等於右邊位置持續執行
            while (left <= right)
            {
                // 持續移動左邊位置，直到找到 大於 pivot 的位置
                while(array[left] < pivot) 
                {
                    left += 1;
                }

                // 持續移動右邊位置，直到找到 小於 pivot 的位置
                while (array[right] > pivot) 
                {
                    right -= 1;
                }

                // 找到對應值且位置尚未交叉，交換數值
                if(left <= right) 
                {
                    int temp = array[right];
                    array[right] = array[left];
                    array[left] = temp;

                    left += 1;
                    right -= 1;
                }
            }

            return left;
        }
    }
}
