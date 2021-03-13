using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Iterator.Sample1
{
    class ReverseIterator<ELEMENT> : Iterator<ELEMENT>
    {
        public Aggregate<ELEMENT> thisAggregate
        {
            get { return aggregate; }
        }
        private Aggregate<ELEMENT> aggregate;

        private int index = 0;

        public ReverseIterator(Aggregate<ELEMENT> _aggregate)
        {
            aggregate = _aggregate;
            index = _aggregate.elements.Count() - 1;
        }

        public bool hasNext()
        {
            return index < 0;
        }

        public ELEMENT next()
        {
            ELEMENT element = aggregate.elements.ToList()[index];

            index--;
            return element;
        }
    }
}
