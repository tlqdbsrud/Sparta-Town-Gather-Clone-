using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    // 입력 처리

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput); // OnMoveEvent로 이동
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim); // 스크린 -> 월드 좌표(변환)
        newAim = (worldPos - (Vector2)transform.position).normalized;// 오브젝트가 마우스 포인터를 바라봄

        if(newAim.magnitude >= 0.9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {

    }
}
