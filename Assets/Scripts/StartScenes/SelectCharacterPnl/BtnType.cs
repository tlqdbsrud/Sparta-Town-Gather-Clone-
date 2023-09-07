using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BtnType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType currentType; // 버튼 종류
    public Transform buttonScale; // 버튼 
    Vector3 defaultScale; // 버튼 크기 

    public GameObject SelectCanvas; // 캐릭터 선택 화면

    public GameObject penguinImage; // 펭귄 이미지
    public GameObject wizardImage; // 마법사 이미지

    private void Start()
    {
       // PlayerPrefs.DeleteKey("SelectedCharacter");
        defaultScale = buttonScale.localScale;
    }

    public void OnBtnclick()
    {

        switch (currentType)
        {
            case BTNType.Penguin:
                penguinImage.gameObject.SetActive(true);
                wizardImage.gameObject.SetActive(false);
                SelectCanvas.gameObject.SetActive(false);
                PlayerPrefs.SetString("SelectedCharacter", "Penguin"); // 선택 캐릭터 PlayerPrefs에 저장

                break;
            case BTNType.Wizard:
                wizardImage.gameObject.SetActive(true);
                penguinImage.gameObject.SetActive(false);
                SelectCanvas.gameObject.SetActive(false);
                PlayerPrefs.SetString("SelectedCharacter", "Wizard"); // 선택 캐릭터 PlayerPrefs에 저장

                break;
            case BTNType.Back:
                SelectCanvas.gameObject.SetActive(false);
                break;
        }
    }

    // 마우스를 버튼 위에 올리면 크기 변화
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.2f;
    }

    // 마우스를 버튼에서 벗어나면 크기 돌아옴
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
