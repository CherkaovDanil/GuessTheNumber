using System;
using System.Collections.Generic;
using Game.UI.UIFramework.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Game.UI.UIGameWindow
{
    public class UIGameWindowController
    {
        private readonly IUIService _uiService;

        private UIGameWindow _uiGameWindow;
        
        private Text _multipliedNumberText;
        private Text _inputField;

        private List<int> listOfNumbers;
        private List<string> listOfNumbersString;

        private string _multipliedNumber;
        private int index;

        public UIGameWindowController(IUIService uiService)
        {
            _uiService = uiService;

            _uiGameWindow = _uiService.Get<UIGameWindow>();

            _multipliedNumberText = _uiGameWindow.GetTheEquationText();
            _inputField = _uiGameWindow.GetInputFiled();

            _uiGameWindow.On_0_OfTheNumberButtonClickEvent += On_0_OfTheNumberButtonClickEventHandler;
            _uiGameWindow.On_1_OfTheNumberButtonClickEvent += On_1_OfTheNumberButtonClickEventHandler;
            _uiGameWindow.On_2_OfTheNumberButtonClickEvent += On_2_OfTheNumberButtonClickEventHandler;
            _uiGameWindow.On_3_OfTheNumberButtonClickEvent += On_3_OfTheNumberButtonClickEventHandler;
            _uiGameWindow.On_4_OfTheNumberButtonClickEvent += On_4_OfTheNumberButtonClickEventHandler;
            _uiGameWindow.On_5_OfTheNumberButtonClickEvent += On_5_OfTheNumberButtonClickEventHandler;
            _uiGameWindow.On_6_OfTheNumberButtonClickEvent += On_6_OfTheNumberButtonClickEventHandler;
            _uiGameWindow.On_7_OfTheNumberButtonClickEvent += On_7_OfTheNumberButtonClickEventHandler;
            _uiGameWindow.On_8_OfTheNumberButtonClickEvent += On_8_OfTheNumberButtonClickEventHandler;
            _uiGameWindow.On_9_OfTheNumberButtonClickEvent += On_9_OfTheNumberButtonClickEventHandler;

            listOfNumbers = new List<int>();
            listOfNumbersString = new List<string>();

            GenerateNumber();

            _uiService.Show<UIGameWindow>();
        }

        private void GenerateNumber()
        {
            var firstNumber = Random.Range(0, 1000);
            var secondNumber = Random.Range(0, 1000);

            _multipliedNumber = (firstNumber * secondNumber).ToString();
            _multipliedNumberText.text = $"{firstNumber} x {secondNumber} = {_multipliedNumber}";


            for (int i = 0; i < _multipliedNumber.Length; i++)
            {
                listOfNumbers.Add(int.Parse(_multipliedNumber[i].ToString()));
                listOfNumbersString.Add("_ ");
            }
            
            for (int i = 0; i < listOfNumbersString.Count; i++)
            {
                _inputField.text += listOfNumbersString[i];
            }
        }

        private void On_0_OfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(0);
        }

        private void On_1_OfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(1);
        }

        private void On_2_OfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(2);
        }

        private void On_3_OfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(3);
        }

        private void On_4_OfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(4);
        }

        private void On_5_OfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(5);
        }

        private void On_6_OfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(6);
        }

        private void On_7_OfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(7);
        }

        private void On_8_OfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(8);
        }

        private void On_9_OfTheNumberButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckTheNumberInNumber(9);
        }

        private void CheckTheNumberInNumber(int number)
        {
            Debug.Log(listOfNumbers[0]);

            if (listOfNumbers[0] == number)
            {
                listOfNumbersString[index] = number.ToString();
                index++;
                _inputField.text = String.Empty;

                for (int i = 0; i < listOfNumbersString.Count; i++)
                {
                    _inputField.text += listOfNumbersString[i];
                }
                listOfNumbers.RemoveAt(0);
            }
        }
    }
}
