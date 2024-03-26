using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{

    public FixedJoystick _joystick;
    public float _moveSpeed;
    public float _rotateSpeed;

    public float _currentSpeed;
    public Animator _animator;
    public CharacterController _characterController;
    public Vector3 _moveVectore;


    public Transform _grouncCheack;
    public LayerMask _layerMask;
    public float _groundDistance;

    private float _Gravity = -9.81f;
    private bool _isGrounded;
    private Vector3 _velocity;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }


    void Update()
    {
        Movementt();
        Gravityy();
    }

    public void Movementt()
    {
        _moveVectore = Vector3.zero;
        _moveVectore.x = _joystick.Horizontal;
        _moveVectore.z = _joystick.Vertical;

        _currentSpeed = _moveVectore.magnitude;

        _animator.SetFloat("Moving", _currentSpeed);

        if (_currentSpeed != 0f)
        {
            Vector3 direction = Vector3.RotateTowards(transform.forward, _moveVectore, _rotateSpeed * Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(direction);
            AnimationRun();
        }
        else if (_currentSpeed == 0)
        {
            AimationIdle();
        }

        _characterController.Move(_moveVectore * _moveSpeed * Time.deltaTime);

    }

    public void AnimationRun()
    {
        _animator.SetBool("Move", true);
    }
    public void AimationIdle()
    {
        _animator.SetBool("Move", false);
    }


    public void Gravityy()
    {
        _isGrounded = Physics.CheckSphere(_grouncCheack.position, _groundDistance, _layerMask);

        if (_velocity.y < 0 && _isGrounded)
        {
            _velocity.y = -2f;
        }

        _velocity.y += _Gravity * Time.deltaTime;
        _characterController.Move(_velocity * Time.deltaTime);
    }
}
