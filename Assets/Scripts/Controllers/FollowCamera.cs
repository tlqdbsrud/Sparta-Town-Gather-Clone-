using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target; // 카메라 따라갈 대상
    public float moveSpeed; // 카메라 따라갈 속도
    private Vector3 targetPosition; // 대상의 현재 위치

    private void Update()
    {
        if (target.gameObject != null) // 대상 존재 확인
        {
            // this: 카메라 의미 (z값: 카메라값 그대로 유지)
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}