using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Iterator_Sample;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ISampleGenerater generater = new IteratorSample();
            generater.generateSample();

            return;
        }
    }
}
