using UnityEngine;
using Zenject;

namespace Game
{
    public class LoseInstaller: MonoInstaller
    {
        [SerializeField] private GameObject[] bodyParts;
        [SerializeField] private ParticleSystem particleSystem;

        public override void InstallBindings()
        {
            Container
                .Bind<LoseController>()
                .AsSingle()
                .NonLazy();
        }
    }
}