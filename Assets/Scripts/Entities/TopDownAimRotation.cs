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
        _controller.OnLookEvent += OnAim; // 구독
    }

    private void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection); // 좌표가 매개변수에 전달
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // 라디안 -> 도수

        armRenderer.flipY = Mathf.Abs(rotZ) > 90f; // 위쪽 향하는지, 아래쪽 향하는지
        characterRenderer.flipX = armRenderer.flipY; // 왼쪽 향하는지, 오른쪽 향하는지
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
