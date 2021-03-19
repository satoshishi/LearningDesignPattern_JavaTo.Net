using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Iterator.Sample2;
using System.Text;
using System.IO;

namespace Adapter.Sample1
{
    public class CSVCollection : CollectionBase<string>
    {
        public override IEnumerable<string> Elements
        {
            get { return elements; }
        }
        private List<string> elements = new List<string>();

        public CSVCollection(string csvText)
        {
            StringReader reader = new StringReader(csvText);

            while (reader.Peek() != -1)
                elements.Add(reader.ReadLine());
        }

        public override IEnumerator<string> GetEnumerator()
        {
            return new SimpleCollection<string>.SimpleIterator<string>(Elements);
        }
    }
}