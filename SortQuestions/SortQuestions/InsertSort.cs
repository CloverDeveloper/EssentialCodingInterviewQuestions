using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortQuestions
{
    /// <summary>
    /// 插入排序法
    /// </summary>
    public class InsertSort
    {
        public int[] Sort(int[] array) 
        {
            int temp = 0;
            for(int i = 1; i < array.Length; i += 1) 
            {
                // 暫存當前值
                temp = array[i];

                // 設定比對範圍
                int j = i;

                // 比對數值，大的往後放，並找到適當位置放入(比前面大，比後面小)
                while(j > 0 && array[j-1] > temp) 
                {
                    array[j] = array[j-1];
                    j -= 1;
                }

                array[j] = temp;
            }

            return array;
        }
    }
}
