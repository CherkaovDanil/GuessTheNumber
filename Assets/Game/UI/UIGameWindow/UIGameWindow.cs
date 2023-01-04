using System;
using Game.UI.UIFramework.Realization;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class UIGameWindow : UICanvasWindow
    {
        [SerializeField] private Button buttonWithNumberOne;
        [SerializeField] private Button buttonWithNumberTwo;
        [SerializeField] private Button buttonWithNumberThree;
        [SerializeField] private Button buttonWithNumberFour;
        [SerializeField] private Button buttonWithNumberFive;
        [SerializeField] private Button buttonWithNumberSix;
        [SerializeField] private Button buttonWithNumberSeven;
        [SerializeField] private Button buttonWithNumberEight;
        [SerializeField] private Button buttonWithNumberNine;
        [SerializeField] private Button buttonWithNumberZero;
        
        [SerializeField] private Button mainMenuButton;

        [SerializeField] private Text equation;
        [SerializeField] private Text inputField;

        public override void Show()
        {
            ShowEvent?.Invoke(this, EventArgs.Empty);
            
            gameObject.SetActive(true);
        
            buttonWithNumberOne.onClick.AddListener(OnOneOfTheNumberButtonClickEventHandler);
            buttonWithNumberTwo.onClick.AddListener(OnTwoOfTheNumberButtonClickEventHandler);
            buttonWithNumberThree.onClick.AddListener(OnThreeOfTheNumberButtonClickEventHandler);
            buttonWithNumberFour.onClick.AddListener(OnFourOfTheNumberButtonClickEventHandler);
            buttonWithNumberFive.onClick.AddListener(OnFiveOfTheNumberButtonClickEventHandler);
            buttonWithNumberSix.onClick.AddListener(OnSixOfTheNumberButtonClickEventHandler);
            buttonWithNumberSeven.onClick.AddListener(OnSevenOfTheNumberButtonClickEventHandler);
            buttonWithNumberEight.onClick.AddListener(OnEightOfTheNumberButtonClickEventHandler);
            buttonWithNumberNine.onClick.AddListener(OnNineOfTheNumberButtonClickEventHandler);
            buttonWithNumberZero.onClick.AddListener(OnZeroOfTheNumberButtonClickEventHandler);
            
            mainMenuButton.onClick.AddListener(OnMenuButtonClickEventHandler);
        }

        public override void Hide()
        {
            HideEvent?.Invoke(this,EventArgs.Empty);
            
            gameObject.SetActive(false);
            
            buttonWithNumberOne.onClick.RemoveListener(OnOneOfTheNumberButtonClickEventHandler);
            buttonWithNumberTwo.onClick.RemoveListener(OnTwoOfTheNumberButtonClickEventHandler);
            buttonWithNumberThree.onClick.RemoveListener(OnThreeOfTheNumberButtonClickEventHandler);
            buttonWithNumberFour.onClick.RemoveListener(OnFourOfTheNumberButtonClickEventHandler);
            buttonWithNumberFive.onClick.RemoveListener(OnFiveOfTheNumberButtonClickEventHandler);
            buttonWithNumberSix.onClick.RemoveListener(OnSixOfTheNumberButtonClickEventHandler);
            buttonWithNumberSeven.onClick.RemoveListener(OnSevenOfTheNumberButtonClickEventHandler);
            buttonWithNumberEight.onClick.RemoveListener(OnEightOfTheNumberButtonClickEventHandler);
            buttonWithNumberNine.onClick.RemoveListener(OnNineOfTheNumberButtonClickEventHandler);
            buttonWithNumberZero.onClick.RemoveListener(OnZeroOfTheNumberButtonClickEventHandler);
            
            mainMenuButton.onClick.RemoveListener(OnMenuButtonClickEventHandler);
        }
        public Text GetTheEquationText()
        {
            return equation;
        }

        public Text GetInputFiled()
        {
            return inputField;
        }

        #region ClickEvents
        public EventHandler OnMenuButtonClickEvent
        {
            get;
            set;
        }
        
        public EventHandler OnOneOfTheNumberButtonClickEvent
        {
            get;
            set;
        }
    
        public EventHandler OnTwoOfTheNumberButtonClickEvent
        {
            get;
            set;
        }
    
        public EventHandler OnThreeOfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler OnFourOfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler OnFiveOfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler OnSixOfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler OnSevenOfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler OnEightOfTheNumberButtonClickEvent
        {
            get;
            set;
        }
    
        public EventHandler OnNineOfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        public EventHandler OnZeroOfTheNumberButtonClickEvent
        {
            get;
            set;
        }
        #endregion

        #region ClickEventHandler
        private void OnOneOfTheNumberButtonClickEventHandler()
        {
            OnOneOfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void OnTwoOfTheNumberButtonClickEventHandler()
        {
            OnTwoOfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void OnThreeOfTheNumberButtonClickEventHandler()
        {
            OnThreeOfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void OnFourOfTheNumberButtonClickEventHandler()
        {
            OnFourOfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void OnFiveOfTheNumberButtonClickEventHandler()
        {
            OnFiveOfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        } 
        private void OnSixOfTheNumberButtonClickEventHandler()
        {
            OnSixOfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        } 
        private void OnSevenOfTheNumberButtonClickEventHandler()
        {
            OnSevenOfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        } 
        private void OnEightOfTheNumberButtonClickEventHandler()
        {
            OnEightOfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void OnNineOfTheNumberButtonClickEventHandler()
        {
            OnNineOfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        private void OnZeroOfTheNumberButtonClickEventHandler()
        {
            OnZeroOfTheNumberButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        
        private void OnMenuButtonClickEventHandler()
        {
            OnMenuButtonClickEvent?.Invoke(this,EventArgs.Empty);
        }
        #endregion
    }
}