using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Adapter.Sample1;
using Adapter;
using Adapter.Sample3;

namespace Adapter
{
    public class AdapterSample : MonoBehaviour,ISampleGenerater
    {
        private IPositionProvider PositionProvider
        {
            get;
            set;
        } = null;

        [SerializeField]
        private LerpPositionProvider m_lerpPositionProv;

        // Start is called before the first frame update
        public void Start()
        {
            generateSample();
        }

        public void generateSample()
        {
            PositionProvider = new CSVPositionProvider((Resources.Load("Coordinates") as TextAsset).text);
            //PositionProvider = m_lerpPositionProv;
        }

        // Update is called once per frame
        public void FixedUpdate()
        {
            if (PositionProvider.TryGetPosition(out Vector3 pos))
                this.transform.position = pos;
        }
    }
}