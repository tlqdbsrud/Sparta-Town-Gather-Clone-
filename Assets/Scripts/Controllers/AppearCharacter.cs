using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearCharacter : MonoBehaviour
{
    public GameObject penguin;
    public GameObject Wizard;

        
    // Start is called before the first frame update
    void Start()
    {
        
        string selectedCharacter = PlayerPrefs.GetString("SelectedCharacter", "Penguin"); // ��� ����1
        Debug.Log("��� ����1");

        if (selectedCharacter == "Penguin")
        {
            Debug.Log("��� ����2");
            penguin.gameObject.SetActive(true);
            Wizard.gameObject.SetActive(false);
        }
        else if (selectedCharacter == "Wizard")
        {
            Debug.Log("������ ����");
            Wizard.gameObject.SetActive(true);
            penguin.gameObject.SetActive(false);
            PlayerPrefs.DeleteKey("SelectedCharacter");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
