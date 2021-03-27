using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TemplateMethod.Sample1
{
    public class CSVWriter : AbstractWriter
    {
        protected override void Output(string text)
        {
            var sw = new StreamWriter(Application.dataPath + "/Sample.csv", true, Encoding.GetEncoding("Shift_JIS"));

            sw.Write(text);
            sw.Close();
        }

        protected override string ToString<T>(List<T> datas)
        {
            string res = string.Empty;

            foreach (T data in datas)
                res += $"{data.ToString()}\n";

            return res;
        }
    }

    public class JsonWriter : AbstractWriter
    {
        [System.Serializable]
        public class JsonData<T>
        {
            public List<T> datas;
        }

        protected override void Output(string text)
        {
            var sw = new StreamWriter(Application.dataPath + "/Sample.json", true, Encoding.GetEncoding("Shift_JIS"));

            sw.Write(text);
            sw.Close();
        }

        protected override string ToString<T>(List<T> datas)
        {
            return JsonUtility.ToJson(
                new JsonData<T>()
                {
                    datas = datas
                }
            );
        }
    }
}