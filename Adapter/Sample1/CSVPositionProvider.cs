using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adapter.Sample1
{
    public class CSVPositionProvider : IPositionProvider
    {
        private CSVCollection Collection
        {
            get;
            set;
        } = null;

        private IEnumerator<string> Iterator
        {
            get;
            set;
        } = null;

        public CSVPositionProvider(string csvText)
        {
            Collection = new CSVCollection(csvText);
            Iterator = Collection.GetEnumerator();
        }

        public bool TryGetPosition(out Vector3 pos)
        {
            pos = Vector3.zero;
            bool isNext = Iterator.MoveNext();

            if(isNext)
            {
                var str = Iterator.Current.Split(',');
                pos = new Vector3(
                    float.Parse(str[0]),
                    float.Parse(str[1]),
                    float.Parse(str[2]));
            }

            return isNext;
        }
    }
}