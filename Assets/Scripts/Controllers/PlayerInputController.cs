using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    // �Է� ó��

    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        
    }

    public void OnLook(InputValue value)
    {

    }

    public void OnFire(InputValue value)
    {

    }
}
