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
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput); // OnMoveEvent�� �̵�
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim); // ��ũ�� -> ���� ��ǥ(��ȯ)
        newAim = (worldPos - (Vector2)transform.position).normalized;// ������Ʈ�� ���콺 �����͸� �ٶ�

        if(newAim.magnitude >= 0.9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {

    }
}
