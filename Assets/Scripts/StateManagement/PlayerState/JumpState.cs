using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.StateManagement.PlayerState
{
    public class JumpState : State
    {
        public override void Enter()
        {
            UnityEngine.Debug.Log("Entering jumping state");
        }

        public override void Exit()
        {
            UnityEngine.Debug.Log("Exiting jumping state");
        }

        public override void Update()
        {
            UnityEngine.Debug.Log("Updating jumping state");
        }

        public override string GetName()
        {
            return "Jump";
        }
    }
}
