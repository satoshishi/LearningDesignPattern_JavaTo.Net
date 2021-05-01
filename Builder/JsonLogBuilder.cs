using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Builder
{

    public class JsonLogBuilder : LogBuilder
    {
        private User loggingTarget = null;

        public JsonLogBuilder() => loggingTarget = new User();

        protected override void SetName(string name)
        {
            loggingTarget.Name = name;
        }

        protected override void SetAge(int age)
        {
            loggingTarget.Age = age;
        }

        protected override void SetSex(bool isMale)
        {
            loggingTarget.IsMale = isMale;
        }

        protected override void SetMailAddress(string address)
        {
            loggingTarget.Address = address;
        }

        protected override void PrintLog()
        {
            string json = JsonUtility.ToJson(loggingTarget);
            // 書き出しとか
        }
    }
}