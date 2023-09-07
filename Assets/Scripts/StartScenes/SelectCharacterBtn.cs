using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterBtn : MonoBehaviour
{
    public Button _button;
    public GameObject ToSelectCanvas;

    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();

    }

   public void OnBtnClick()
    {
        ToSelectCanvas.gameObject.SetActive(true);
    }
}
