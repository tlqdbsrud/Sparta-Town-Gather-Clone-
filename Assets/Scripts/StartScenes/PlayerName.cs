using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerName : MonoBehaviour
{
    public TMP_Text playerName; // ĳ���� �̸� ����
    

    private void Start()
    {
        playerName = GetComponent<TMP_Text>(); // UI �ؽ�Ʈ �ҷ�����

        string savedName = PlayerPrefs.GetString("PlayerName", "");
        // PlayerPrefs: PlayerName(UI �ؽ�Ʈ)�̶�� Ű�� ����� ���� �ҷ����� ����
        // ("PlayerName",""): "PlayerName"�� �����͸� �ĺ��ϴ� ������ Ű�̸�, �� Ű�� ����Ͽ� ����� �� �˻�
        // ("PlayerName",""): " "�� �⺻���̸�, �� "PlayerName"�̶�� Ű�� ����� �����Ͱ� ���� ��� �� ���ڿ�("") ��ȯ

        playerName.text = savedName; // savedName�� ������ playerName UI �ؽ�Ʈ�� �Էµ�.
                                     // ("PlayerName", "���") -> PlayerName(UI text)
    }
}
