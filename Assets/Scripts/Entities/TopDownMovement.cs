using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private Rigidbody2D _rigidbody;

    private Vector2 _movementDirection = Vector2.zero;
    

    private void Awake()
    {
        // 불러오기
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _controller.OnMoveEvent += Move; // 이동(Move) 구독
    }

    // 물리적 처리
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction) // 예) 플레이어가 오른쪽으로 이동하면 direction 매개변수에
                                         //     (1,0)을 전달한다. _movementDirection 변수에 (1,0)이
                                         //     저장되고, TopDownCharacterController 객체는 플레이어를
                                         //     오른쪽으로 이동시킬 것이다.
    {
        _movementDirection = direction;
    }

    // 이동 처리
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction; // 가속도 저장
    }
}
