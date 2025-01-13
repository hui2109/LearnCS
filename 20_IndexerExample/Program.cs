using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_IndexerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s["KKK"] == null);

            s["yu wen"] = 98;  // set方法
            Console.WriteLine(s["yu wen"]);  // get方法

            try
            {
                s["shu xue"] = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

    class Student
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();

        // 构造一个索引器，方便录入学生的科目及对应成绩
        // code snippet：indexer
        public int? this[string subject]
        {
            get
            {
                /* return the specified index here */
                if (scoreDictionary.ContainsKey(subject))  // 如果有相应科目的成绩，才返回该成绩；否则返回 null
                {
                    return scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                /* set the specified index to value here */
                // 如果set的值是空值,则报错
                if (value.HasValue == false)
                {
                    throw new Exception("Score can not be null.");
                }

                if (scoreDictionary.ContainsKey(subject))  // 如果有相应科目的成绩，则更新该成绩；否则设置对应科目的成绩
                {
                    scoreDictionary[subject] = value.Value;
                }
                else
                {
                    scoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }
}
