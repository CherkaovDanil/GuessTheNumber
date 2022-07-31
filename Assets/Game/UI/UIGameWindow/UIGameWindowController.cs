using Game.UI.UIFramework.Interfaces;

namespace Game.UI.UIGameWindow
{
    public class UIGameWindowController
    {
        private readonly IUIService _uiService;

        private UIGameWindow _uiGameWindow;

        public UIGameWindowController(IUIService uiService)
        {
            _uiService = uiService;
        }
        
        
        public void InitCalibrationMenu()
        {
            _uiGameWindow = _uiService.Get<UIGameWindow>();
        }
    }
}