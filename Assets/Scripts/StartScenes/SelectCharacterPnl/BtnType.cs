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

    public GameObject penguinImage; // ��� �̹���
    public GameObject wizardImage; // ������ �̹���

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
                PlayerPrefs.SetString("SelectedCharacter", "Penguin"); // ���� ĳ���� PlayerPrefs�� ����

                break;
            case BTNType.Wizard:
                wizardImage.gameObject.SetActive(true);
                penguinImage.gameObject.SetActive(false);
                SelectCanvas.gameObject.SetActive(false);
                PlayerPrefs.SetString("SelectedCharacter", "Wizard"); // ���� ĳ���� PlayerPrefs�� ����

                break;
            case BTNType.Back:
                SelectCanvas.gameObject.SetActive(false);
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
