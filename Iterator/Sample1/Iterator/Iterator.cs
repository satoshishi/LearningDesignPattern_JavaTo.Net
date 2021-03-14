using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Sample1
{
    public interface Iterator<ELEMENT>
    {
        //Aggregate側から参照するのはIEnumerableだけ
        Aggregate<ELEMENT> thisAggregate { get; }

        bool hasNext();

        ELEMENT next();
    }
}
