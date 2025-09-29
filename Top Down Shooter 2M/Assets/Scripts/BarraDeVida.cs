using UnityEngine;
using UnityEngine.UIElements;

public class BarraDeVida : MonoBehaviour
{
    public Personagem personagem;
    public Slider slider;
    
    void Start()
    {
        if (personagem != null && slider != null)
        {
            slider.lowValue = 0;
            slider.highValue = personagem.getVida();
            
            slider.value = personagem.getVida();
        }

    }

    void Update()
    {
        slider.value = personagem.getVida();
    }
}
