using System;
using Game.UI.UIFramework.Realization;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class UIMainMenuWindow : UICanvasWindow
    {
        [SerializeField] private Button playButton;
        [SerializeField] private Button rulesButton;
        [SerializeField] private Button exitButton;
        
        public override void Show()
        {
            ShowEvent?.Invoke(this, EventArgs.Empty);
            gameObject.SetActive(true);
            
            playButton.onClick.AddListener(OnPlayButtonClickEventHandler);
            rulesButton.onClick.AddListener(OnRulesButtonClickEventHandler);
            exitButton.onClick.AddListener(OnExitButtonClickEventHandler);
        }

        public override void Hide()
        {
            HideEvent?.Invoke(this,EventArgs.Empty);
            gameObject.SetActive(false);
            
            playButton.onClick.RemoveListener(OnPlayButtonClickEventHandler);
            rulesButton.onClick.RemoveListener(OnRulesButtonClickEventHandler);
            exitButton.onClick.RemoveListener(OnExitButtonClickEventHandler);
        }
        
        private void OnPlayButtonClickEventHandler()
        {
            OnPlayButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void OnRulesButtonClickEventHandler()
        {
            OnRulesButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void OnExitButtonClickEventHandler()
        {
            OnExitButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        
        public EventHandler OnPlayButtonClickEvent
        {
            get;
            set;
        }
    
        public EventHandler OnRulesButtonClickEvent
        {
            get;
            set;
        }
    
        public EventHandler OnExitButtonClickEvent
        {
            get;
            set;
        }
    }
}