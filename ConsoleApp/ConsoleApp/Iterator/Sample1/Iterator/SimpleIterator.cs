using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Iterator.Sample1
{
    /// <summary>
    /// 名前が全く思いつかん
    /// </summary>
    public class SimpleIterator<ELEMENT> : Iterator<ELEMENT>
    {
        public Aggregate<ELEMENT> thisAggregate
        {
            get { return aggregate; }
        }
        private Aggregate<ELEMENT> aggregate;

        private int index = 0;

        public SimpleIterator(Aggregate<ELEMENT> _aggregate)
        {
            aggregate = _aggregate;
        }

        public bool hasNext()
        {
            return aggregate.elements.ToList().Count <= index;
        }

        public ELEMENT next()
        {
            ELEMENT element = aggregate.elements.ToList()[index];

            index++;
            return element;
        }
    }
}
