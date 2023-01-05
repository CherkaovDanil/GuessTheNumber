using Game.Camera;
using Game.UI.UIFramework.Installer;
using Zenject;

namespace Game
{
    public class ApplicationInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            UIFrameworkInstaller.Install(Container);
            
            CameraInstaller.Install(Container);

            Container
                .Bind<ApplicationLauncher>()
                .AsSingle()
                .NonLazy();
        }
    }
}