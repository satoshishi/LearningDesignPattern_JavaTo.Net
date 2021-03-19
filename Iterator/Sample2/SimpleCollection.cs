using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Sample2
{
    class SimpleCollection<ELEMENT> : CollectionBase<ELEMENT>
    {
        public override IEnumerable<ELEMENT> Elements
        {
            get { return elements; }
        }
        private List<ELEMENT> elements = new List<ELEMENT>();

        public override void Add(ELEMENT element)
        {
            elements.Add(element);
        }

        public override IEnumerator<ELEMENT> GetEnumerator()
        {
            return new SimpleIterator<ELEMENT>(Elements);
        }

        #region IEnumerator

        #region シンプルなイテレータ  

        public class SimpleIterator<_ELEMENT> : IEnumerator<_ELEMENT>
        {
            public IEnumerable<_ELEMENT> elements
            {
                get;
                private set;
            } = new List<_ELEMENT>();

            public int index
            {
                get;
                private set;
            } = -1;

            public SimpleIterator(IEnumerable<_ELEMENT> _elements)
            {
                elements = _elements;
            }

            public bool MoveNext()
            {
                index++;

                return index < elements.ToArray().Length;
            }

            public void Reset()
            {
                index = -1;
            }

            public _ELEMENT Current
            {
                get { return elements.ToArray()[index]; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public void Dispose()
            {
            }
        }

        #endregion

        #region 逆向きから探索するイテレータ

        class ReverseIterator<_ELEMENT> : IEnumerator<_ELEMENT>
        {
            public IEnumerable<_ELEMENT> elements
            {
                get;
                private set;
            } = new List<_ELEMENT>();

            public int index
            {
                get;
                private set;
            } = -1;

            public ReverseIterator(IEnumerable<_ELEMENT> _elements)
            {
                elements = _elements;
                index = elements.ToList().Count;
            }

            public bool MoveNext()
            {
                index--;

                return index >= 0;
            }

            public void Reset()
            {
                index = elements.ToList().Count;
            }

            public _ELEMENT Current
            {
                get { return elements.ToList()[index]; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public void Dispose()
            {
            }
        }

        #endregion

        #endregion

    }
}
