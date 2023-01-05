using Game.SceneObject;
using Game.Scripts;
using Zenject;

namespace Game
{
    public class ApplicationLaunchCommand: Command
    {
        private readonly IInstantiator _instantiator;
        
        public ApplicationLaunchCommand(
            IInstantiator instantiator)
        {
            _instantiator = instantiator;
        }
        
        public override void Execute()
        {
            _instantiator.InstantiatePrefabResourceForComponent<DesertSceneObject>("DesertSceneObject");
            _instantiator.InstantiatePrefabResourceForComponent<EventSystemSceneObject>("EventSystemSceneObject");
        }
    }
}