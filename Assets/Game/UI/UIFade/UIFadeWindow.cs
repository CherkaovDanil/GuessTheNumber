using System;
using Game.UI.UIFramework.Realization;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class UIFadeWindow : UICanvasWindow
    {
        [SerializeField] private Image fade;
        
        public override void Show()
        {
            ShowEvent?.Invoke(this, EventArgs.Empty);
            gameObject.SetActive(true);
        }

        public override void Hide()
        {
            HideEvent?.Invoke(this,EventArgs.Empty);
            gameObject.SetActive(false);
        }

        public Image GetFade()
        {
            return fade;
        }
    }
}