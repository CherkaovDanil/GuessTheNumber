using Game.UI.UIFramework.Interfaces;
using System;
using UnityEngine;

namespace Game.UI
{
    public class UIMainMenuWindowController
    {
        private readonly IUIService _uiService;
        private readonly UIGameWindowController _uiGameWindowController;

        private UIMainMenuWindow _uiMainMenuWindow;
        
        
        public UIMainMenuWindowController(
            IUIService uiService,
            UIGameWindowController uiGameWindowController)
        {
            _uiService = uiService;
            _uiGameWindowController = uiGameWindowController;

            _uiMainMenuWindow = _uiService.Get<UIMainMenuWindow>();

            _uiMainMenuWindow.OnPlayButtonClickEvent += OnPlayButtonClickEventHandler;
            _uiMainMenuWindow.OnRulesButtonClickEvent += OnRulesButtonClickEventHandler;
            _uiMainMenuWindow.OnExitButtonClickEvent += OnExitButtonClickEventHandler;
            
            _uiService.Show<UIMainMenuWindow>();
        }
        
        private void OnPlayButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UIMainMenuWindow>();
            _uiService.Show<UIGameWindow>();
            
            _uiGameWindowController.StartNewGame();
        }
        
        private void OnRulesButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UIMainMenuWindow>();
            _uiService.Show<UIRulesWindow>();
        }
        private void OnExitButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UIMainMenuWindow>();
            Application.Quit();
        }
    }
}