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
        // �ҷ�����
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _controller.OnMoveEvent += Move; // �̵�(Move) ����
    }

    // ������ ó��
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction) // ��) �÷��̾ ���������� �̵��ϸ� direction �Ű�������
                                         //     (1,0)�� �����Ѵ�. _movementDirection ������ (1,0)��
                                         //     ����ǰ�, TopDownCharacterController ��ü�� �÷��̾
                                         //     ���������� �̵���ų ���̴�.
    {
        _movementDirection = direction;
    }

    // �̵� ó��
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction; // ���ӵ� ����
    }
}
