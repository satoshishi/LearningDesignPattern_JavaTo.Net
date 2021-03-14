using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Sample2
{
    class IteratorSample2 : ISampleGenerater
    {
        /// <summary>
        /// c#で標準で用意されているIteratorっぽいものを継承して作ってみたバージョン
        /// </summary>
        public void generateSample()
        {
            CollectionBase<string> collection = new SimpleCollection<string>();
            collection.Add("a");
            collection.Add("b");
            collection.Add("c");

            //IEnumerableを継承しているから、foreachで回せる！
            foreach (string val in collection)
                Console.Write(val + "\n");

            //IEnumerableを継承しているから、Linqが使える！
            var res = collection.Where(c => c.Equals("a")).ToList()[0];
            Console.Write(res);
        }
    }
}
