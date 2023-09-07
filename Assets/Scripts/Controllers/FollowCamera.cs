using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target; // ī�޶� ���� ���
    public float moveSpeed; // ī�޶� ���� �ӵ�
    private Vector3 targetPosition; // ����� ���� ��ġ

    private void Start()
    {

    }

    private void Update()
    {
        // "Player" �±׸� ���� ������Ʈ�� ã��
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            // ī�޶��� z ��ġ�� �����ϰ� x�� y ��ġ�� ����� ��ġ�� ����
            targetPosition.Set(player.transform.position.x, player.transform.position.y, transform.position.z);

            // Lerp �Լ��� ����Ͽ� �ε巴�� ���󰡱�
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        Debug.Log("ī�޶�");
    }
}