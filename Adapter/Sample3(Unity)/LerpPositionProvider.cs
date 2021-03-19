using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adapter
{
    public class LerpPositionProvider : MonoBehaviour,IPositionProvider
    {    
        [SerializeField]
        private Transform m_poitn1;

        [SerializeField]
        private Transform m_point2;

        public bool TryGetPosition(out Vector3 pos)
        {
            pos = Vector3.zero;

            if(m_poitn1 == null || m_point2 == null) 
                return false;  

            pos = Vector3.Lerp(m_poitn1.position,m_point2.position,0.5f);
            return true;                         
        }
    }
}