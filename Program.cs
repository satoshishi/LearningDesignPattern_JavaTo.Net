using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        ISampleGenerater generater = new IteratorSample2();
        generater.generateSample();

        return;
    }
}
