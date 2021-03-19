using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Adapter.Sample1;
using Adapter;

namespace Adapter
{
    public class Main : MonoBehaviour
    {
        private IPositionProvider PositionProvider
        {
            get;
            set;
        } = null;

        [SerializeField]
        private LerpPositionProvider m_lerpPositionProv;

        // Start is called before the first frame update
        void Start()
        {
            PositionProvider = new CSVPositionProvider((Resources.Load("Coordinates") as TextAsset).text);
            //PositionProvider = m_lerpPositionProv;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (PositionProvider.TryGetPosition(out Vector3 pos))
                this.transform.position = pos;
        }
    }
}