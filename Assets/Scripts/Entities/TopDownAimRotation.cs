using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
   
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;


    private TopDownCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();    
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim; // ����
    }

    private void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection); // ��ǥ�� �Ű������� ����
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // ���� -> ����

        armRenderer.flipY = Mathf.Abs(rotZ) > 90f; // ���� ���ϴ���, �Ʒ��� ���ϴ���
        characterRenderer.flipX = armRenderer.flipY; // ���� ���ϴ���, ������ ���ϴ���
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
