using System;
using Game.UI.UIFade;
using Game.UI.UIFramework.Interfaces;
using Game.UI.UIGameWindow;
using UnityEngine;

namespace Game.UI.UIMainMenuWindow
{
    public class UIMainMenuWindowController
    {
        private readonly IUIService _uiService;
        private readonly UIGameWindowController _uiGameWindowController;
        private readonly UIFadeController _uiFadeController;

        private UI.UIMainMenuWindow.UIMainMenuWindow _uiMainMenuWindow;

        public UIMainMenuWindowController(
            IUIService uiService,
            UIGameWindowController uiGameWindowController, 
            UIFadeController uiFadeController)
        {
            _uiService = uiService;
            _uiGameWindowController = uiGameWindowController;
            _uiFadeController = uiFadeController;

            _uiMainMenuWindow = _uiService.Get<UI.UIMainMenuWindow.UIMainMenuWindow>();

            _uiMainMenuWindow.OnPlayButtonClickEvent += OnPlayButtonClickEventHandler;
            _uiMainMenuWindow.OnRulesButtonClickEvent += OnRulesButtonClickEventHandler;
            _uiMainMenuWindow.OnExitButtonClickEvent += OnExitButtonClickEventHandler;
            
            _uiService.Show<UI.UIMainMenuWindow.UIMainMenuWindow>();
            
            _uiService.Show<UIFadeWindow>();
            
            _uiFadeController.FadeOut();
        }
        
        private void OnPlayButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UI.UIMainMenuWindow.UIMainMenuWindow>();
            _uiService.Show<UIGameWindow.UIGameWindow>();
            
            _uiGameWindowController.StartNewGame();
        }
        
        private void OnRulesButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UI.UIMainMenuWindow.UIMainMenuWindow>();
            _uiService.Show<UIRulesWindow.UIRulesWindow>();
        }
        private void OnExitButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UI.UIMainMenuWindow.UIMainMenuWindow>();
            Application.Quit();
        }
    }
}