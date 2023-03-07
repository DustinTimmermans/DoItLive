
namespace Assets.Scripts.StateManagement.PlayerState
{
    public class RunState : State
    {
        public override void Enter()
        {
            UnityEngine.Debug.Log("Entering running state");
        }

        public override void Exit()
        {
            UnityEngine.Debug.Log("Exiting running state");
        }

        public override void Update()
        {
            UnityEngine.Debug.Log("Updating running state");
        }

        public override string GetName()
        {
            return "Run";
        }
    }
}
