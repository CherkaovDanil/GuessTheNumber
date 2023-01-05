using Game.Scripts;
using Zenject;

namespace Game.Camera
{
    public class CameraInstaller: Installer<CameraInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<CameraViewProtocolConfig>()
                .FromScriptableObjectResource("CameraViewProtocolConfig")
                .AsSingle();

            Container
                .BindFactory<SceneObjectProtocol, CameraView, CameraView.Factory>()
                .FromMonoPoolableMemoryPool(
                    x => x.FromComponentInNewPrefabResource("Main Camera"));

            Container
                .Bind<CameraController>()
                .AsSingle()
                .NonLazy();
        }
    }
}