using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Slider sliderVidasRestantes;
    
    public Persoangem persoangem;
    [SerializeField] private int vidasRestantes = 0;
    
    void Start()
    {
        if (persoangem != null & sliderVidasRestantes != null)
        {
            sliderVidasRestantes.minValue = 0;
            sliderVidasRestantes.maxValue = persoangem.getVida();
        }
    }

  
    void Update()
    {
        if (sliderVidasRestantes != null)
        {
            vidasRestantes = persoangem.getVida();
            sliderVidasRestantes.value = vidasRestantes;
        }
    }
}
