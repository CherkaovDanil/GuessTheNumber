using System;
using Game.UI.UIFramework.Interfaces;
using Game.UI.UIGameWindow;
using UnityEngine.Events;

namespace Game.UI.UIDeathWindow
{
    public class UIDeathMenuController
    {
        public UnityEvent OnResetAnimation = new UnityEvent();
        
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
            OnResetAnimation.Invoke();
            
            _uiService.Hide<UIDeathWindow>();
            _uiService.Show<UIMainMenuWindow.UIMainMenuWindow>();
        }
        
        private void OnPlayAgainButtonClickEventHandler(object sender, EventArgs e)
        {
            OnResetAnimation.Invoke();
            
            _uiService.Hide<UIDeathWindow>();
            _uiService.Show<UIGameWindow.UIGameWindow>();
            
            _uiGameWindowController.StartNewGame();
        }
    }
}