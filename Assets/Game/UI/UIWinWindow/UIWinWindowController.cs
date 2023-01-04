using System;
using Game.UI.UIFramework.Interfaces;
using UnityEngine.Events;

namespace Game.UI
{
    public class UIWinWindowController
    {
        public UnityEvent OnResetAnimation = new UnityEvent();
        
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
            OnResetAnimation.Invoke();
            
            _uiService.Hide<UIWinWindow>();
            _uiService.Show<UIMainMenuWindow>();
        }
        
        private void OnPlayAgainButtonClickEventHandler(object sender, EventArgs e)
        {
            OnResetAnimation.Invoke();
            
            _uiService.Hide<UIWinWindow>();
            _uiService.Show<UIGameWindow>();
            
            _uiGameWindowController.StartNewGame();
        }
    }
}