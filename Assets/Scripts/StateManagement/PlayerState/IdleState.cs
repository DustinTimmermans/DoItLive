using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;

namespace Assets.Scripts.StateManagement.PlayerState
{
    public class IdleState : State
    {
        public override void Enter()
        {
            UnityEngine.Debug.Log("Entering idle state");
        }

        public override void Exit()
        {
            UnityEngine.Debug.Log("Exiting idle state");
        }

        public override void Update()
        {
            UnityEngine.Debug.Log("Updating idle state");
        }

        public override string GetName()
        {
            return "Idle";
        }
    }
}
