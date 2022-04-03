using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortQuestions
{
    /// <summary>
    /// 合併排序法
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// 排序陣列
        /// </summary>
        /// <param name="array"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public int[] Sort(int[] array) 
        {
            this.SplitAndMergeSort(array, 0, array.Length - 1);

            return array;
        }

        /// <summary>
        /// 分割後合併排序
        /// </summary>
        private void SplitAndMergeSort(int[] array, int l, int r) 
        {
            // 指標左大於右時停止分割
            if (l >= r) return;

            // 取得中間值
            int m = (l + r) / 2;

            // 持續分割左邊陣列
            SplitAndMergeSort(array, l, m);

            // 持續分割右邊陣列
            SplitAndMergeSort(array, m + 1, r);

            this.SortArray(array, l, m, r);

        }

        /// <summary>
        /// 合併排序
        /// </summary>
        /// <param name="array">陣列</param>
        /// <param name="l">左邊位置</param>
        /// <param name="m">中間位置</param>
        /// <param name="r">右邊位置</param>
        private void SortArray(int[] array, int l, int m, int r)
        {
            // 0 0 1
            // 取得合併排序用存陣列大小(左跟右)

            // 0-0+1
            int lLength = (m - l) + 1;

            // 1 - 0
            int rLength = r - m;

            // 建立暫存資料陣列
            int[] lArray = new int[lLength];
            int[] rArray = new int[rLength];

            // 給暫存陣列設值
            for (int i = 0; i < lLength; i+=1) 
            {
                lArray[i] = array[l+i];
            }

            for (int j = 0; j < rLength; j++)
            {
                rArray[j] = array[m + 1 + j];
            }

            // 初始化左右暫存陣列起始位置
            int lIndex = 0;
            int rIndex = 0;

            // 初始化排序陣列位置為左
            int originIndex = l;
            while (lIndex < lLength && rIndex < rLength)
            {
                // 左大於右
                if (lArray[lIndex] >= rArray[rIndex])
                {
                    array[originIndex] = rArray[rIndex];

                    rIndex += 1;
                }
                else // 左小於右 
                {
                    array[originIndex] = lArray[lIndex];

                    lIndex += 1;
                }

                originIndex += 1;
            }

            // 將未排序值依序補上
            while(lIndex < lLength) 
            {
                array[originIndex] = lArray[lIndex];

                lIndex += 1;
                originIndex += 1;
            }

            while (rIndex < rLength)
            {
                array[originIndex] = rArray[rIndex];

                rIndex += 1;
                originIndex += 1;
            }
        }
    }
}
