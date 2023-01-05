using ArcadeSnake;
using Game.UI.UIDeathWindow;
using Game.UI.UIFade;
using Game.UI.UIFramework.Interfaces;
using Game.UI.UIFramework.Realization;
using Game.UI.UIGameWindow;
using Game.UI.UIMainMenuWindow;
using Game.UI.UIRulesWindow;
using Game.UI.UIWinWindow;
using Zenject;

namespace Game.UI.UIFramework.Installer 
{
    public class UIFrameworkInstaller : Installer<UIFrameworkInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<IUIRoot>()
                .To<UIRoot>()
                .FromComponentInNewPrefabResource("UIRoot")
                .AsSingle()
                .NonLazy();

            Container
                .Bind<IUIService>()
                .To<UIService>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<UIController>()
                .AsSingle()
                .NonLazy();

            Container
                .Bind<UIGameWindowController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<UIMainMenuWindowController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<UIRulesWindowController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<UIWinWindowController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<UIDeathMenuController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<UIFadeController>()
                .AsSingle()
                .NonLazy();
        }
    }
}
