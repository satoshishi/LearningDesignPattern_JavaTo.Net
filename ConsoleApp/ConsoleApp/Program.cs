using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Iterator.Sample1;
using ConsoleApp.Iterator.Sample2;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ISampleGenerater generater = new IteratorSample2();
            generater.generateSample();

            return;
        }
    }
}
