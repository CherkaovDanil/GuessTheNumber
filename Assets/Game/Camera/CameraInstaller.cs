using UnityEngine;
using Zenject;

namespace Game
{
    public class CameraInstaller: MonoInstaller<CameraInstaller>
    {
        [SerializeField] private CameraView cameraView;
        [SerializeField] private CameraViewProtocolConfig protocolConfig;
        
        public override void InstallBindings()
        {
            Container
                .Bind<CameraViewProtocolConfig>()
                .FromScriptableObject(protocolConfig)
                .AsSingle();

            Container
                .BindFactory<SceneObjectProtocol, CameraView, CameraView.Factory>()
                .FromMonoPoolableMemoryPool(
                    x => x.FromComponentInNewPrefab(cameraView));

            Container
                .Bind<CameraController>()
                .AsSingle()
                .NonLazy();
        }
    }
}