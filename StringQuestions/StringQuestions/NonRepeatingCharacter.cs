using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQuestions
{
    /// <summary>
    /// 取得非重複字元 O(n)
    /// </summary>
    public class NonRepeatingCharacter
    {
        /// <summary>
        /// 取得非重複字元
        /// </summary>
        /// <returns></returns>
        public string GetNonRepeatingCharacter(string str)
        {
            return this.Video(str);
        }

        /// <summary>
        /// 自己解法
        /// </summary>
        /// <param name="str">輸入字串</param>
        /// <returns></returns>
        private string MyAns(string str) 
        {
            // 存放已重複字元
            List<char> repeats = new List<char>();

            // 存放初次出現字元
            List<char> nonRepeats = new List<char>();
            for (int i = 0; i < str.Length; i += 1)
            {
                // 若此字元已重複出現，繼續執行下一個
                if (repeats.IndexOf(str[i]) != -1)
                {
                    continue;
                }

                // 若此字元初次出現就新增
                if (nonRepeats.IndexOf(str[i]) == -1)
                {
                    nonRepeats.Add(str[i]);
                }
                else // 第 2 次出現就存放到重複字元集合，並清除初次出現集合的對應值
                {
                    repeats.Add(str[i]);
                    nonRepeats.Remove(str[i]);
                }
            }

            return nonRepeats.Count == 0 ? null : nonRepeats[0].ToString();
        }

        /// <summary>
        /// 影片解法
        /// </summary>
        /// <param name="str">輸入字串</param>
        /// <returns></returns>
        private string Video(string str) 
        {
            // 記錄用字典
            Dictionary<char,int> recordDic = new Dictionary<char,int>();

            for(int i = 0; i < str.Length; i += 1) 
            {
                // 若字元不存在就新增
                if (!recordDic.ContainsKey(str[i])) 
                {
                    recordDic.Add(str[i], 1);
                }
                else // 已存在就更新次數
                {
                    recordDic[str[i]] += 1;
                }
            }

            // 取得次數為 1 的回傳
            for(int i = 0; i < str.Length; i += 1) 
            {
                if (recordDic[str[i]] == 1) 
                    return str[i].ToString();
            }

            // 尚未回傳就回傳 null
            return null;
        }
    }
}
