using System;
using Game.UI.UIFramework.Realization;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI.UIGameWindow
{
    public class UIGameWindow : UICanvasWindow
    {
        [SerializeField] private Button _1numberButton;
        [SerializeField] private Button _2numberButton;
        [SerializeField] private Button _3numberButton;
        [SerializeField] private Button _4numberButton;
        [SerializeField] private Button _5numberButton;
        [SerializeField] private Button _6numberButton;
        [SerializeField] private Button _7numberButton;
        [SerializeField] private Button _8numberButton;
        [SerializeField] private Button _9numberButton;
        [SerializeField] private Button _0numberButton;

        public override void Show()
        {
            ShowEvent?.Invoke(this, EventArgs.Empty);
            gameObject.SetActive(true);
        
            _1numberButton.onClick.AddListener(On_1_OfTheNumberButtonClickEventHandler);
            _2numberButton.onClick.AddListener(On_2_OfTheNumberButtonClickEventHandler);
            _3numberButton.onClick.AddListener(On_3_OfTheNumberButtonClickEventHandler);
            _4numberButton.onClick.AddListener(On_4_OfTheNumberButtonClickEventHandler);
            _5numberButton.onClick.AddListener(On_5_OfTheNumberButtonClickEventHandler);
            _6numberButton.onClick.AddListener(On_6_OfTheNumberButtonClickEventHandler);
            _7numberButton.onClick.AddListener(On_7_OfTheNumberButtonClickEventHandler);
            _8numberButton.onClick.AddListener(On_8_OfTheNumberButtonClickEventHandler);
            _9numberButton.onClick.AddListener(On_9_OfTheNumberButtonClickEventHandler);
            _0numberButton.onClick.AddListener(On_0_OfTheNumberButtonClickEventHandler);
        }

        public override void Hide()
        {
            HideEvent?.Invoke(this,EventArgs.Empty);
            gameObject.SetActive(false);
            
            _1numberButton.onClick.RemoveListener(On_1_OfTheNumberButtonClickEventHandler);
            _2numberButton.onClick.RemoveListener(On_2_OfTheNumberButtonClickEventHandler);
            _3numberButton.onClick.RemoveListener(On_3_OfTheNumberButtonClickEventHandler);
            _4numberButton.onClick.RemoveListener(On_4_OfTheNumberButtonClickEventHandler);
            _5numberButton.onClick.RemoveListener(On_5_OfTheNumberButtonClickEventHandler);
            _6numberButton.onClick.RemoveListener(On_6_OfTheNumberButtonClickEventHandler);
            _7numberButton.onClick.RemoveListener(On_7_OfTheNumberButtonClickEventHandler);
            _8numberButton.onClick.RemoveListener(On_8_OfTheNumberButtonClickEventHandler);
            _9numberButton.onClick.RemoveListener(On_9_OfTheNumberButtonClickEventHandler);
            _0numberButton.onClick.RemoveListener(On_0_OfTheNumberButtonClickEventHandler);
        }
    
        public EventHandler On_1_OfTheNumberButtonClickEvent
        {
            get;
            set;
        }
    
        public EventHandler On_2_OfTheNumberButtonClickEvent
        {
            get;
            set;
        }
    
        public EventHandler On_3_OfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler On_4_OfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler On_5_OfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler On_6_OfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler On_7_OfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler On_8_OfTheNumberButtonClickEvent
        {
            get;
            set;
        }
    
        public EventHandler On_9_OfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler On_0_OfTheNumberButtonClickEvent
        {
            get;
            set;
        }
    
    
        private void On_1_OfTheNumberButtonClickEventHandler()
        {
            On_1_OfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void On_2_OfTheNumberButtonClickEventHandler()
        {
            On_2_OfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void On_3_OfTheNumberButtonClickEventHandler()
        {
            On_3_OfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void On_4_OfTheNumberButtonClickEventHandler()
        {
            On_4_OfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void On_5_OfTheNumberButtonClickEventHandler()
        {
            On_5_OfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        } 
        private void On_6_OfTheNumberButtonClickEventHandler()
        {
            On_6_OfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        } 
        private void On_7_OfTheNumberButtonClickEventHandler()
        {
            On_7_OfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        } 
        private void On_8_OfTheNumberButtonClickEventHandler()
        {
            On_8_OfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void On_9_OfTheNumberButtonClickEventHandler()
        {
            On_9_OfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void On_0_OfTheNumberButtonClickEventHandler()
        {
            On_0_OfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
    }
}
