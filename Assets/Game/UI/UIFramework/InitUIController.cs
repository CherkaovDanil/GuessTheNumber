﻿using Game.UI.UIFramework.Interfaces;
using Game.UI.UIGameWindow;
using UnityEngine;

namespace Game.UI.UIFramework
{
    public class InitUICommand : Command
    {
        private readonly IUIRoot _uIRoot;
        private readonly IUIService _uIService;
        private readonly UIGameWindowController _uiGameWindowController;


        public InitUICommand(IUIRoot uIRoot, 
            IUIService uIService,
            UIGameWindowController uiGameWindowController)
        {
            _uIRoot = uIRoot;
            _uIService = uIService;
            _uiGameWindowController = uiGameWindowController;
        }

        public override void Execute()
        {
            _uIService.LoadWindows();
            var container = new GameObject("DeactivatedWindows");
            var containerRect = container.AddComponent<RectTransform>();
            containerRect.SetParent(_uIRoot.Container);
            containerRect.localScale = Vector3.one;
            containerRect.anchorMin = Vector2.zero;
            containerRect.anchorMax = Vector2.one;
            containerRect.pivot = new Vector2(0.5f, 0.5f);
            containerRect.offsetMin = Vector2.zero;
            containerRect.offsetMax = Vector2.zero;

            container.gameObject.SetActive(false);

            _uIService.InitWindows(containerRect);
            _uiGameWindowController.InitCalibrationMenu();

            OnDone();
        }
    }
}