using Game.UI.UIFramework.Interfaces;
using UnityEngine;
using Zenject;

namespace ArcadeSnake
{
    public class UIRoot : MonoBehaviour, IUIRoot
    {
        [SerializeField] private Canvas canvas;
        [SerializeField] private Camera camera;
        [SerializeField] private Transform container;
        [SerializeField] private Transform poolContainer;

        public Canvas Canvas
        {
            get => canvas;
            set => canvas = value;
        }
        
        public Camera Camera
        {
            get => camera;
            set => camera = value;
        }

        public Transform Container => container;

        public Transform PoolContainer => poolContainer;
    }
}
