using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CRT_FX : MonoBehaviour
{
    private Toggle _toggle;
    public TextMeshProUGUI _text;
    void Start()
    {
        _toggle = GetComponent<Toggle>();
    }

    void Update()
    {

        if (_toggle.isOn == true)
        {
            _text.text = "Ligado";
            _text.color = Color.green;   
        }
        else
        {
            _text.text = "Desligado";
            _text.color = Color.red;
        }

    }
}
