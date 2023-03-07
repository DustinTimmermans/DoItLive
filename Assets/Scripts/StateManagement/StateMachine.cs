using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.StateManagement
{
    public class StateMachine
    {
        private State _currentState;

        public void ChangeState(State newState)
        {
            _currentState?.Exit();
            _currentState = newState;
            _currentState.Enter();
        }

        public void Update()
        {
            _currentState?.Update();
        }

        public bool IsInState(Type type)
        {
            // return if the _currentState is the same type as state
            return type == _currentState.GetType();
        }

        public State GetState()
        {
            return _currentState;
        }
    }
}
