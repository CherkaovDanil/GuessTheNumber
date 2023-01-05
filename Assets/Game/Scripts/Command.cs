using System;

namespace Game.Scripts
{
    public abstract class Command
    {
        public abstract void Execute();
        public event EventHandler DoneEvent;

        protected virtual void OnDone()
        {
            DoneEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}