using UnityEngine;

namespace Game.UI.UIFramework.Interfaces
{
    public interface IUIRoot
    {
        Canvas Canvas { get; set; }
        UnityEngine.Camera Camera { get; set; }
        Transform Container { get; }
        Transform PoolContainer { get; }
    }
}
