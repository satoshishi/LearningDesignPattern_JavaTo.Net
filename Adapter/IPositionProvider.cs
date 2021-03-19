using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adapter
{
    public interface IPositionProvider
    {
        bool TryGetPosition(out Vector3 pos);
    }
}