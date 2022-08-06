using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "CameraViewProtocolConfig", menuName = "Config/CameraViewProtocolConfig", order = 0) ]
    public class CameraViewProtocolConfig : ScriptableObject
    {
        public SceneObjectProtocol Protocol;
    }
}