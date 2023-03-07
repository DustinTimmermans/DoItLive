
namespace Assets.Scripts.StateManagement
{
    public abstract class State
    {
        public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();
        public abstract string GetName();
    }
}
