using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Iterator_Sample
{
    public interface Iterator<ELEMENT>
    {
        //Aggregate側から参照するのはIEnumerableだけ
        Aggregate<ELEMENT> thisAggregate { get; }

        bool hasNext();

        ELEMENT next();
    }
}
