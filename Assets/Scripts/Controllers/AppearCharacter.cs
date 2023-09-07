using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearCharacter : MonoBehaviour
{
    public GameObject penguinPrefab;
    public GameObject WizardPrefab;

        
    // Start is called before the first frame update
    void Start()
    {
        string selectedCharacter = PlayerPrefs.GetString("SelectedCharacter", "Penguin");

        if (selectedCharacter == "Penguin")
        {
            Debug.Log("��� ����");
            Instantiate(penguinPrefab); // ��� ����
            PlayerPrefs.DeleteKey("SelectedCharacter");

        }
        else if (selectedCharacter == "Wizard")
        {
            Debug.Log("������ ����");
            Instantiate(WizardPrefab); // ������ ����
            PlayerPrefs.DeleteKey("SelectedCharacter");

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
