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
        string selectedCharacter = PlayerPrefs.GetString("SelectedCharacter", "");

        if (selectedCharacter == "Penguin")
        {
            Instantiate(penguinPrefab);
        }
        else if (selectedCharacter == "Wizard")
        {
            Instantiate(WizardPrefab);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
