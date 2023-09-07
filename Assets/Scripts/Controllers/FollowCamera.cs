using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target; // 카메라 따라갈 대상
    public float moveSpeed; // 카메라 따라갈 속도
    private Vector3 targetPosition; // 대상의 현재 위치

    private void Start()
    {

    }

    private void Update()
    {
        // "Player" 태그를 가진 오브젝트를 찾음
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            // 카메라의 z 위치는 유지하고 x와 y 위치를 대상의 위치로 설정
            targetPosition.Set(player.transform.position.x, player.transform.position.y, transform.position.z);

            // Lerp 함수를 사용하여 부드럽게 따라가기
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        Debug.Log("카메라");
    }
}