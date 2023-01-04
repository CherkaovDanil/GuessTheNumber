using System;
using System.Collections.Generic;
using Game.UI.UIFramework.Interfaces;
using UnityEngine.Events;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Game.UI
{
    public class UIGameWindowController
    {
        public UnityEvent OnAddBodyPart = new UnityEvent();
        public UnityEvent OnResetAnimation = new UnityEvent();
        
        private readonly IUIService _uiService;
        
        private const int _maxCountMistakes = 5;
        
        private UIGameWindow _uiGameWindow;
        
        private Text _multipliedNumberText;
        private Text _inputField;

        private List<int> listOfNumbers;
        private List<int> listOfUsingNumbers;
        private List<string> listOfNumbersString;

        private string _multipliedNumber;
        
        private int _mistakeCounter;

        public UIGameWindowController(IUIService uiService)
        {
            _uiService = uiService;

            _uiGameWindow = _uiService.Get<UIGameWindow>();

            _multipliedNumberText = _uiGameWindow.GetTheEquationText();
            _inputField = _uiGameWindow.GetInputFiled();

            _uiGameWindow.OnZeroOfTheNumberButtonClickEvent += OnZeroOfTheNumberButtonClickEventHandler;
            _uiGameWindow.OnOneOfTheNumberButtonClickEvent += OnOneOfTheNumberButtonClickEventHandler;
            _uiGameWindow.OnTwoOfTheNumberButtonClickEvent += OnTwoOfTheNumberButtonClickEventHandler;
            _uiGameWindow.OnThreeOfTheNumberButtonClickEvent += OnThreeOfTheNumberButtonClickEventHandler;
            _uiGameWindow.OnFourOfTheNumberButtonClickEvent += OnFourTheNumberButtonClickEventHandler;
            _uiGameWindow.OnFiveOfTheNumberButtonClickEvent += OnFiveOfTheNumberButtonClickEventHandler;
            _uiGameWindow.OnSixOfTheNumberButtonClickEvent += OnSixOfTheNumberButtonClickEventHandler;
            _uiGameWindow.OnSevenOfTheNumberButtonClickEvent += OnSevenOfTheNumberButtonClickEventHandler;
            _uiGameWindow.OnEightOfTheNumberButtonClickEvent += OnEightOfTheNumberButtonClickEventHandler;
            _uiGameWindow.OnNineOfTheNumberButtonClickEvent += OnNineOfTheNumberButtonClickEventHandler;
            
            _uiGameWindow.OnMenuButtonClickEvent +=OnMenuButtonClickEventHandler;

            listOfNumbers = new List<int>();
            listOfUsingNumbers = new List<int>();
            listOfNumbersString = new List<string>();
        }

        public void StartNewGame()
        {
            listOfNumbers.Clear();
            listOfUsingNumbers.Clear();
            listOfNumbersString.Clear();
            _inputField.text = String.Empty;

            _mistakeCounter = 0;

            var firstNumber = Random.Range(0, 100);
            var secondNumber = Random.Range(0, 100);

            _multipliedNumber = (firstNumber * secondNumber).ToString();
            _multipliedNumberText.text = $"{firstNumber} x {secondNumber} = {_multipliedNumber}";

            for (int i = 0; i < _multipliedNumber.Length; i++)
            {
                listOfNumbers.Add(int.Parse(_multipliedNumber[i].ToString()));
                listOfNumbersString.Add("_ ");
            }

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                _inputField.text += listOfNumbersString[i];
            }
        }

        #region ClickEventHadlerRegion

        private void OnZeroOfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(0);
        }

        private void OnOneOfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(1);
        }

        private void OnTwoOfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(2);
        }

        private void OnThreeOfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(3);
        }

        private void OnFourTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(4);
        }

        private void OnFiveOfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(5);
        }

        private void OnSixOfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(6);
        }

        private void OnSevenOfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(7);
        }

        private void OnEightOfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(8);
        }

        private void OnNineOfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(9);
        }
        private void OnMenuButtonClickEventHandler(object sender, EventArgs e)
        {
            OnResetAnimation.Invoke();
            _uiService.Hide<UIGameWindow>();
            _uiService.Show<UIMainMenuWindow>();
        }

        #endregion
        
        
        private void CheckTheNumberInNumber(int number)
        {
            if (listOfUsingNumbers.Contains(number) || !listOfNumbers.Contains(number))
            {
                AddPartOfBody();
            }
            else
            {
               PrintTheNumber(number);
            }
        }
        
        
        private void AddPartOfBody()
        {
            OnAddBodyPart.Invoke();
            _mistakeCounter++;
            if (_mistakeCounter >= _maxCountMistakes)
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            _uiService.Hide<UIGameWindow>();
            _uiService.Show<UIDeathWindow>();
        }

        private void PrintTheNumber(int number)
        {
            _inputField.text = String.Empty;
            
            listOfUsingNumbers.Add(number);

            var listOfIndexs = new List<int>();
                
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] == number)
                {
                    listOfIndexs.Add(i);
                }
            }

            foreach (var index in listOfIndexs)
            {
                listOfNumbersString[index] = $"{number} ";
            }

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                _inputField.text += listOfNumbersString[i];
            }


            if (!listOfNumbersString.Contains("_ "))
            {
                _uiService.Hide<UIGameWindow>();
                _uiService.Show<UIWinWindow>();
            }
        }
    }
}
