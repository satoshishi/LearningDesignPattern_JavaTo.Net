using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TemplateMethod.Sample1
{
    public abstract class AbstractWriter
    {
        protected abstract void Output(string text);

        protected abstract string ToString<T>(List<T> datas);

        public void Handle<T>(List<T> datas)
        {
            string text = ToString<T>(datas);

            Output(text);
        }
    }
}