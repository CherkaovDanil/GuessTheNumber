using System;
using Game.UI.UIFramework.Interfaces;

namespace Game.UI
{
    public class UIDeathMenuController
    {
        private readonly IUIService _uiService;
        private readonly UIGameWindowController _uiGameWindowController;

        private UIDeathWindow _uiDeathWindow;
        
        public UIDeathMenuController(IUIService uiService,
            UIGameWindowController uiGameWindowController)
        {
            _uiService = uiService;
            _uiGameWindowController = uiGameWindowController;

            _uiDeathWindow = _uiService.Get<UIDeathWindow>();
            
            _uiDeathWindow.MainMenuButtonClickEvent += OnMenuButtonClickEventHandler;
            _uiDeathWindow.PlayAgainButtonClickEvent += OnPlayAgainButtonClickEventHandler;
        }
        
        private void OnMenuButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UIDeathWindow>();
            _uiService.Show<UIMainMenuWindow>();
        }
        
        private void OnPlayAgainButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UIDeathWindow>();
            _uiService.Show<UIGameWindow>();
            
            _uiGameWindowController.StartNewGame();
        }
    }
}