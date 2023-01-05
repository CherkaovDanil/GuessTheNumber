using Game.Scripts;
using UnityEngine;

namespace Game.Camera
{
    [CreateAssetMenu(fileName = "CameraViewProtocolConfig", menuName = "Config/CameraViewProtocolConfig", order = 0) ]
    public class CameraViewProtocolConfig : ScriptableObject
    {
        public SceneObjectProtocol Protocol;
    }
}