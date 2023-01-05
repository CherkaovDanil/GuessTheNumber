using System;
using Game.UI.UIFramework.Realization;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI.UIRulesWindow
{
    public class UIRulesWindow : UICanvasWindow
    {
        [SerializeField] private Button mainMenuButton;
        
        public override void Show()
        {
            ShowEvent?.Invoke(this, EventArgs.Empty);
            gameObject.SetActive(true);
            mainMenuButton.onClick.AddListener(OnMenuButtonClickEventHandler);
        }

        public override void Hide()
        {
            HideEvent?.Invoke(this,EventArgs.Empty);
            gameObject.SetActive(false);
            
            mainMenuButton.onClick.RemoveListener(OnMenuButtonClickEventHandler);
        }
        
        public EventHandler OnMenuButtonClickEvent
        {
            get;
            set;
        }
        
        private void OnMenuButtonClickEventHandler()
        {
            OnMenuButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
    }
}