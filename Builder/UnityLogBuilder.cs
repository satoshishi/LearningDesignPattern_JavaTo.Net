using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Builder
{
    public class UnityLogBuilder : LogBuilder
    {
        private List<string> loggingTarget;

        public UnityLogBuilder() => loggingTarget = new List<string>();

        protected override void SetName(string name)
        {
            loggingTarget.Add(name);
        }

        protected override void SetAge(int age)
        {
            loggingTarget.Add(age.ToString());
        }

        protected override void SetSex(bool isMale)
        {
            loggingTarget.Add(isMale ? "male" : "female"); 
        }

        protected override void SetMailAddress(string address)
        {
            loggingTarget.Add(address); 
        }

        protected override void PrintLog()
        {
            foreach(string log in loggingTarget)
                Debug.Log(log);

            loggingTarget = new List<string>();
        }
    }
}