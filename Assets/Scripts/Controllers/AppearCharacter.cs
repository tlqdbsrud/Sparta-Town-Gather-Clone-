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
        
        string selectedCharacter = PlayerPrefs.GetString("SelectedCharacter", "Penguin"); // Æë±Ï µîÀå1
        Debug.Log("Æë±Ï µîÀå1");

        if (selectedCharacter == "Penguin")
        {
            Debug.Log("Æë±Ï µîÀå2");
            penguin.gameObject.SetActive(true);
            Wizard.gameObject.SetActive(false);
        }
        else if (selectedCharacter == "Wizard")
        {
            Debug.Log("¸¶¹ý»ç µîÀå");
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
