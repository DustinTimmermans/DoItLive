using System;
using System.Diagnostics;
using UnityEngine;

namespace Assets.Scripts.StateManagement.PlayerState
{
    public class MoveState : State
    {
        public override void Enter()
        {
            UnityEngine.Debug.Log("Entering moving state");
        }

        public override void Exit()
        {
            UnityEngine.Debug.Log("Exiting moving state");
        }

        public override void Update()
        {
            UnityEngine.Debug.Log("Updating moving state");
        }

        public override string GetName()
        {
            return "Move";
        }
    }
}
