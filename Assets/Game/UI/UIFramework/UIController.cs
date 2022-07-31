using Zenject;

namespace Game.UI.UIFramework
{
    public class UIController
    {
        private readonly IInstantiator _instantiator; 
        
        public UIController(
        IInstantiator instantiator)
        { 
            _instantiator = instantiator;
            
            var command = _instantiator.Instantiate<InitUICommand>(); 
            command.Execute(); 
        }
    }
}