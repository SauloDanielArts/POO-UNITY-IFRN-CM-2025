using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    private GameObject player;
    public Slider slider;
   
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        if (player != null && slider != null)
        {
            slider.maxValue = player.GetComponent<Player>().vida;
        }
        
    }

  
    void Update()
    {
        if (player != null && slider != null)
        {
            slider.value = player.GetComponent<Player>().vida;
        }

    }
}
