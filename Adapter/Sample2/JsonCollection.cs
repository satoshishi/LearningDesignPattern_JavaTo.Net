using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Iterator.Sample2;
using System.Text;
using System.IO;

namespace Adapter.Sample2
{
    public class JsonCollection : CollectionBase<CoordinateList.Coordinate>
    {
        public override IEnumerable<CoordinateList.Coordinate> Elements
        {
            get { return elements; }
        }
        private List<CoordinateList.Coordinate> elements = new List<CoordinateList.Coordinate>();

        public JsonCollection(string jsonText)
        {
            elements = JsonUtility.FromJson<CoordinateList>(jsonText).list;
        }

        public override IEnumerator<CoordinateList.Coordinate> GetEnumerator()
        {
            return new SimpleCollection<CoordinateList.Coordinate>.SimpleIterator<CoordinateList.Coordinate>(Elements);
        }
    }
}