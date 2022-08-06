using System;
using Game.UI.UIFramework.Interfaces;

namespace Game.UI
{
    public class UIWinWindowController
    {
        private readonly IUIService _uiService;
        private readonly UIGameWindowController _uiGameWindowController;

        private UIWinWindow _uiWinWindow;


        public UIWinWindowController(IUIService uiService,UIGameWindowController uiGameWindowController)
        {
            _uiService = uiService;
            _uiGameWindowController = uiGameWindowController;

            _uiWinWindow = _uiService.Get<UIWinWindow>();
            
            _uiWinWindow.MainMenuButtonClickEvent += OnMenuButtonClickEventHandler;
            _uiWinWindow.PlayAgainButtonClickEvent += OnPlayAgainButtonClickEventHandler;
        }
        
        private void OnMenuButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UIWinWindow>();
            _uiService.Show<UIMainMenuWindow>();
        }
        
        private void OnPlayAgainButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UIWinWindow>();
            _uiService.Show<UIGameWindow>();
            
            _uiGameWindowController.StartNewGame();
        }
    }
}