using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Sample1
{
    public interface Aggregate<ELEMENT>
    {
        //イテレータ側にAggregateの実装に依存して欲しくなかったから、
        //IEnumerableからArrayだけアクセスするようにしてみた
        IEnumerable<ELEMENT> elements { get; }
    }
}
