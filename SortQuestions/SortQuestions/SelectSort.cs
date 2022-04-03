using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortQuestions
{
    /// <summary>
    /// 選擇排序法
    /// </summary>
    public class SelectSort
    {
        public int[] Sort(int[] array) 
        {
            int minIndex = 0;
            int temp = 0;
            for(int i = 0; i < array.Length; i += 1) 
            {
                minIndex = i;

                // 不斷更新最小值位置
                for(int j = i+1;j<array.Length; j += 1) 
                {
                    if(array[minIndex] > array[j]) 
                    {
                        minIndex = j;
                    }
                }

                // 將最小值放置當前次數的最前端
                temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }

            return array;
        }
    }
}
