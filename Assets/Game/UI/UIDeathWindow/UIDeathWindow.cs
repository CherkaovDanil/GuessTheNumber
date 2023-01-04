using System;
using Game.UI.UIFramework.Realization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.UI
{
    public class UIDeathWindow : UICanvasWindow
    {
        public UnityEvent OnResetAnimation = new UnityEvent();
        
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
            OnResetAnimation.Invoke();
            PlayAgainButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void MainMenuButtonClickEventHandler()
        {
            OnResetAnimation.Invoke();
            MainMenuButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        
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
        
    }
}