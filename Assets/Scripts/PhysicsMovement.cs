using Assets.Scripts.StateManagement;
using Assets.Scripts.StateManagement.PlayerState;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsMovement : MonoBehaviour
{
    private StateMachine _stateMachine;

    private Rigidbody _rigidBody;

    private Vector2 _movement;

    public PlayerStateText _playerStateText;

    [SerializeField]
    private float _speed = 10f;

    [SerializeField]
    private float _run = 1.2f;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();

        _stateMachine = new StateMachine();
        var idle = new IdleState();

        _stateMachine.ChangeState(idle);

        _playerStateText = GameObject.FindGameObjectWithTag("PlayerState").GetComponent<PlayerStateText>();
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * new Vector3(_movement.x, 0, _movement.y));
        _playerStateText.UpdateName(_stateMachine.GetState().GetName());
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ground"))
        {
            // If player hits ground, transition to Idle state
            State state = _movement.x != 0 || _movement.y != 0 ? new MoveState() : new IdleState();
            _stateMachine.ChangeState(state);
        }
    }

    private void OnMove(InputValue value)
    {
        // Move the player
        _movement = value.Get<Vector2>();
        State state = _movement.Equals(Vector2.zero) ? new IdleState() : new MoveState();
        _stateMachine.ChangeState(state);
    }

    private void OnJump(InputValue value)
    {
        if (!_stateMachine.IsInState(typeof(JumpState)))
        {
            // Player is not in the air (anymore), ability to jump and transition to Jump state
            _rigidBody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            _stateMachine.ChangeState(new JumpState());
        }
    }

    private void OnRun(InputValue value)
    {
        if (value.isPressed && _stateMachine.IsInState(typeof(MoveState)))
        {
            // Player has started running, transition to Run state
            _movement *= _run;
            _stateMachine.ChangeState(new RunState());
        }
        else if (!value.isPressed && !_stateMachine.IsInState(typeof(MoveState)))
        {
            _stateMachine.ChangeState(new IdleState());
        }
        else if (!value.isPressed)
        {
            // Player has stopped running, transition to Move state
            _movement /= _run;
            _stateMachine.ChangeState(new MoveState());
        }
    }
}
