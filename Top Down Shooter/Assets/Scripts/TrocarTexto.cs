using TMPro;
using UnityEngine;

public class TrocarTexto : MonoBehaviour
{
    public TextMeshProUGUI _texto;
    public TMP_InputField _inputField;
 
    public void Trocar()
    {
       _texto.text = _inputField.text; 
    }
}
