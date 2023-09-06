using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InputFieldMinimumLength : MonoBehaviour
{
    private TMP_InputField _inputField;
    public Button _button; // 버튼에 대한 참조
    public TMP_Text _text;

    private void Start()
    {
        _inputField = GetComponent<TMP_InputField>(); // 인풋필드 참조

        _inputField.onEndEdit.AddListener(OnClick);
        // 입력 필드의 입력이 완료되었을 때 실행할 메서드 또는 이벤트 핸들러를 연결

        _button = GameObject.Find("JoinBtn").GetComponent<Button>(); // 버튼 참조

        _text = GameObject.Find("CharacterLimitText").GetComponent<TMP_Text>(); // 텍스트 참조
    }

    private void OnClick(string text)
    {
        if (text.Length < 2)
        {
            _button.interactable = false; // 버튼 비활성화
            _text.text = "Please enter at least 2 characters.";
        }
        else
        {
            _button.interactable = true; // 버튼 활성화
            _text.text = "";
        }
    }
}