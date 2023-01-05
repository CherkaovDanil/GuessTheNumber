using System;
using Game.UI.UIFramework.Interfaces;
using Game.UI.UIGameWindow;
using UnityEngine.Events;

namespace Game.UI.UIWinWindow
{
    public class UIWinWindowController
    {
        public UnityEvent OnResetAnimation = new UnityEvent();
        
        private readonly IUIService _uiService;
        private readonly UIGameWindowController _uiGameWindowController;

        private UI.UIWinWindow.UIWinWindow _uiWinWindow;

        public UIWinWindowController(IUIService uiService,UIGameWindowController uiGameWindowController)
        {
            _uiService = uiService;
            _uiGameWindowController = uiGameWindowController;

            _uiWinWindow = _uiService.Get<UI.UIWinWindow.UIWinWindow>();
            
            _uiWinWindow.MainMenuButtonClickEvent += OnMenuButtonClickEventHandler;
            _uiWinWindow.PlayAgainButtonClickEvent += OnPlayAgainButtonClickEventHandler;
        }
        
        private void OnMenuButtonClickEventHandler(object sender, EventArgs e)
        {
            OnResetAnimation.Invoke();
            
            _uiService.Hide<UI.UIWinWindow.UIWinWindow>();
            _uiService.Show<UIMainMenuWindow.UIMainMenuWindow>();
        }
        
        private void OnPlayAgainButtonClickEventHandler(object sender, EventArgs e)
        {
            OnResetAnimation.Invoke();
            
            _uiService.Hide<UI.UIWinWindow.UIWinWindow>();
            _uiService.Show<UIGameWindow.UIGameWindow>();
            
            _uiGameWindowController.StartNewGame();
        }
    }
}