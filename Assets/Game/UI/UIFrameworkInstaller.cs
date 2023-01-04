using ArcadeSnake;
using Game.UI.UIFramework.Interfaces;
using Game.UI.UIFramework.Realization;
using UnityEngine;
using Zenject;

namespace Game.UI.UIFramework.Installer 
{
    public class UIFrameworkInstaller : MonoInstaller
    {
        [SerializeField] private UIRoot uiRootPrefab;

        public override void InstallBindings()
        {
            Container
                .Bind<IUIRoot>()
                .To<UIRoot>()
                .FromComponentInNewPrefab(uiRootPrefab)
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
