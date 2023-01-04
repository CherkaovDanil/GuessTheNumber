using System;
using Game.UI.UIFramework.Realization;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class UIWinWindow: UICanvasWindow
    {
        public EventHandler PlayAgainButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler MainMenuButtonClickEvent
        {
            get;
            set;
        }

        [SerializeField] private Button playAgainButton;
        [SerializeField] private Button mainMenuButton;
        
        public override void Show()
        {
            ShowEvent?.Invoke(this, EventArgs.Empty);
            gameObject.SetActive(true);
            
            playAgainButton.onClick.AddListener(PlayAgainButtonClickEventHandler);
            mainMenuButton.onClick.AddListener(MainMenuButtonClickEventHandler);
        }

        public override void Hide()
        {
            HideEvent?.Invoke(this,EventArgs.Empty);
            gameObject.SetActive(false);
            
            playAgainButton.onClick.RemoveListener(PlayAgainButtonClickEventHandler);
            mainMenuButton.onClick.RemoveListener(MainMenuButtonClickEventHandler);
        }
        
        private void PlayAgainButtonClickEventHandler()
        {
            PlayAgainButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void MainMenuButtonClickEventHandler()
        {
            MainMenuButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
    }
}