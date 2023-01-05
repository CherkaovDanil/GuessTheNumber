using DG.Tweening;
using Game.UI.UIFramework.Interfaces;
using UnityEngine.UI;

namespace Game.UI.UIFade
{
    public class UIFadeController
    {
        private readonly IUIService _uiService;

        private UIFadeWindow _uiFadeWindowWindow;

        private Image _fade;

        public UIFadeController(IUIService uiService)
        {
            _uiService = uiService;
            
            _uiFadeWindowWindow = _uiService.Get<UIFadeWindow>();

            _fade = _uiFadeWindowWindow.GetFade();
        }

        public void FadeIn()
        {
            _fade.DOFade(1, 2.5f);
        }

        public void FadeOut()
        {
            _fade.DOFade(0, 2.5f);
        }
    }
}