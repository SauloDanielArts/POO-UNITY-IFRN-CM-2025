using UnityEngine;
using UnityEngine.UI;

public class PinelArmas : MonoBehaviour
{
    private Image image;
    
    public Sprite[] sprites;
     void Start()
    {
        image = gameObject.GetComponent<Image>();
        image.sprite = sprites[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            image.sprite = sprites[0];
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            image.sprite = sprites[1];
        }
    }
}
