using System;
using Game.UI.UIFramework.Interfaces;

namespace Game.UI.UIRulesWindow
{
    public class UIRulesWindowController
    {
        private readonly IUIService _uiService;
        
        private UI.UIRulesWindow.UIRulesWindow _uiRulesWindow;

        public UIRulesWindowController(IUIService uiService)
        {
            _uiService = uiService;
            
            _uiRulesWindow = _uiService.Get<UI.UIRulesWindow.UIRulesWindow>();

            _uiRulesWindow.OnMenuButtonClickEvent += OnMenuButtonClickEventHandler;
        }
        private void OnMenuButtonClickEventHandler(object sender, EventArgs e)
        {
            _uiService.Hide<UI.UIRulesWindow.UIRulesWindow>();
            _uiService.Show<UIMainMenuWindow.UIMainMenuWindow>();
        }
    }
}