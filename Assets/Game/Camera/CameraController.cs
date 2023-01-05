using UnityEngine;

namespace Game.Camera
{
    public class CameraController
    {
        private readonly CameraViewProtocolConfig _cameraViewProtocolConfig;
        private readonly CameraView.Factory _cameraFactory;

        private CameraView _camera;
        private CanvasGroup _fade;

        public CameraController(
            CameraViewProtocolConfig cameraViewProtocolConfig,
            CameraView.Factory cameraFactory)
        {
            _cameraViewProtocolConfig = cameraViewProtocolConfig;
            _cameraFactory = cameraFactory;

            _camera = _cameraFactory.Create(_cameraViewProtocolConfig.Protocol);
        }
    }
}