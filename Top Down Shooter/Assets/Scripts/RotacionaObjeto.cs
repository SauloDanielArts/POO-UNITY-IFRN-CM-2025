using UnityEngine;
using UnityEngine.UI;

public class RotacionaObjeto : MonoBehaviour
{
    public GameObject objeto;
    public Slider slider;
    void Update()
    {
        objeto.transform.rotation = Quaternion.Euler(0, 0, slider.value);
        
        objeto.GetComponent<SpriteRenderer>().color = new Color(slider.value*(13.14f/180), 0, 0);
    }
}
