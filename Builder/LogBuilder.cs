using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Builder
{
    public class User
    {
        public string Name;

        public int Age;

        public bool IsMale;

        public string Address;
    }

    public abstract class LogBuilder
    {
        public void Handle(User user)
        {
            SetName(user.Name);
            SetAge(user.Age);
            SetSex(user.IsMale);
            SetMailAddress(user.Address);
            
            PrintLog();
        }

        protected abstract void SetName(string name);

        protected abstract void SetAge(int age);

        protected abstract void SetSex(bool isMale);

        protected abstract void SetMailAddress(string address);

        protected abstract void PrintLog();
    }
}