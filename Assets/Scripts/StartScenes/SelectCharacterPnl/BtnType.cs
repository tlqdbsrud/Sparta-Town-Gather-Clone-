using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BtnType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType currentType; // ��ư ����
    public Transform buttonScale; // ��ư 
    Vector3 defaultScale; // ��ư ũ�� 

    public GameObject SelectCanvas; // ĳ���� ���� ȭ��

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
                Debug.Log("���");

                break;
            case BTNType.Wizard:
                SceneManager.LoadScene("SampleScene");
                Debug.Log("������");
                break;
            case BTNType.Back:
                SelectCanvas.gameObject.SetActive(false);
                Debug.Log("�ڷΰ���");
                break;
        }
    }

    // ���콺�� ��ư ���� �ø��� ũ�� ��ȭ
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.2f;
    }

    // ���콺�� ��ư���� ����� ũ�� ���ƿ�
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
