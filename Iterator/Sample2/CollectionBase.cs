using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Sample2
{
    public abstract class CollectionBase<ELEMENT> : IEnumerable<ELEMENT>
    {
        public abstract IEnumerable<ELEMENT> Elements{get;}

        public virtual void Add(ELEMENT element){}

        public virtual IEnumerator<ELEMENT> GetEnumerator()
        {
            foreach (ELEMENT element in Elements)
                yield return element;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
