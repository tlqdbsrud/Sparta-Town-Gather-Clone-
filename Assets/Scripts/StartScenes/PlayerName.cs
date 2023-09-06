using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerName : MonoBehaviour
{
    public TMP_Text playerName; // 캐릭터 이름 설정
    

    private void Start()
    {
        playerName = GetComponent<TMP_Text>(); // UI 텍스트 불러오기

        string savedName = PlayerPrefs.GetString("PlayerName", "");
        // PlayerPrefs: PlayerName(UI 텍스트)이라는 키로 저장된 값을 불러오는 역할
        // ("PlayerName",""): "PlayerName"은 데이터를 식별하는 고유한 키이며, 이 키를 사용하여 저장된 값 검색
        // ("PlayerName",""): " "는 기본값이며, 즉 "PlayerName"이라는 키에 연결된 데이터가 없을 경우 빈 문자열("") 반환

        playerName.text = savedName; // savedName의 내용이 playerName UI 텍스트에 입력됨.
                                     // ("PlayerName", "펭귄") -> PlayerName(UI text)
    }
}
