using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Adapter;
using Iterator.Sample2;
using System.Text;
using System.IO;

namespace Adapter.Sample2
{
    #region json

    [System.Serializable]
    public class CoordinateList
    {
        [System.Serializable]
        public class Coordinate
        {
            public float x;
            public float y;
            public float z;
        }

        public List<Coordinate> list;
    }

    #endregion

    public class JsonPositionProvider : CollectionBase<CoordinateList.Coordinate>,IPositionProvider
    {
        public override IEnumerable<CoordinateList.Coordinate> Elements
        {
            get { return elements; }
        }
        private List<CoordinateList.Coordinate> elements = new List<CoordinateList.Coordinate>();

        private IEnumerator<CoordinateList.Coordinate> Iterator
        {
            get;
            set;
        } = null;

        public JsonPositionProvider(string jsonText)
        {
            elements = JsonUtility.FromJson<CoordinateList>(jsonText).list;
            Iterator = GetEnumerator();
        }

        public override IEnumerator<CoordinateList.Coordinate> GetEnumerator()
        {
            return new SimpleCollection<CoordinateList.Coordinate>.SimpleIterator<CoordinateList.Coordinate>(Elements);
        }                

        public bool TryGetPosition(out Vector3 pos)
        {
            pos = Vector3.zero;
            bool isNext = Iterator.MoveNext();

            if (isNext)
            {
                var coordinate = Iterator.Current;
                pos = new Vector3(
                    coordinate.x,
                    coordinate.y,
                    coordinate.z);
            }

            return isNext;
        }
    }
}