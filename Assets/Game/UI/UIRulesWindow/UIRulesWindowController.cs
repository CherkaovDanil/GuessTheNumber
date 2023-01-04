using System;
using Game.UI.UIFramework.Interfaces;

namespace Game.UI
{
    public class UIRulesWindowController
    {
        private readonly IUIService _uiService;
        
        private UIRulesWindow _uiRulesWindow;

        public UIRulesWindowController(IUIService uiService)
        {
            _uiService = uiService;
            
            _uiRulesWindow = _uiService.Get<UIRulesWindow>();

            _uiRulesWindow.OnMenuButtonClickEvent += OnMenuButtonClickEventHandler;
        }
        private void OnMenuButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UIRulesWindow>();
            _uiService.Show<UIMainMenuWindow>();
        }
    }
}