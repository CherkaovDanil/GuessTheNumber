using System;
using UnityEngine;

namespace Game.Scripts
{
    [Serializable]
    public struct SceneObjectProtocol
    {
        public Vector3 Position;

        public SceneObjectProtocol(Vector3 position)
        {
            Position = position;
        }
    }
}