using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InputFieldMinimumLength : MonoBehaviour
{
    private TMP_InputField _inputField;
    public Button _button; // ��ư�� ���� ����
    public TMP_Text _text;

    private void Start()
    {
        _inputField = GetComponent<TMP_InputField>(); // ��ǲ�ʵ� ����

        _inputField.onEndEdit.AddListener(OnClick);
        // �Է� �ʵ��� �Է��� �Ϸ�Ǿ��� �� ������ �޼��� �Ǵ� �̺�Ʈ �ڵ鷯�� ����

        _button = GameObject.Find("JoinBtn").GetComponent<Button>(); // ��ư ����

        _text = GameObject.Find("CharacterLimitText").GetComponent<TMP_Text>(); // �ؽ�Ʈ ����
    }

    private void OnClick(string text)
    {
        if (text.Length < 2)
        {
            _button.interactable = false; // ��ư ��Ȱ��ȭ
            _text.text = "Please enter at least 2 characters.";
        }
        else
        {
            _button.interactable = true; // ��ư Ȱ��ȭ
            _text.text = "";
        }
    }
}