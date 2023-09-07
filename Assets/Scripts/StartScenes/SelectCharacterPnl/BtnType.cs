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

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }

    public void OnBtnclick()
    {
        switch (currentType)
        {
            case BTNType.Penguin:
                SceneManager.LoadScene("SampleScene");
                Debug.Log("펭귄");

                break;
            case BTNType.Wizard:
                SceneManager.LoadScene("SampleScene");
                Debug.Log("마법사");
                break;
            case BTNType.Back:
                SelectCanvas.gameObject.SetActive(false);
                Debug.Log("뒤로가기");
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
