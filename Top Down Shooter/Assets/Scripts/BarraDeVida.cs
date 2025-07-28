using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Slider sliderVidasRestantes;
    public Slider sliderEnergiaRestate;
    
    public Personagem personagem;
    [SerializeField]
    private int vidasRestantes = 0;
    [SerializeField]
    private int energiaRestate = 0;
    
  
    void Start()
    {
        if (personagem == null)
        {
            //jogador = GameObject.Find("Jogador").GetComponent<Jogador>();
            personagem = GameObject.FindWithTag("Player").GetComponent<Jogador>();
        }

        if (personagem != null)
        {
            if (sliderVidasRestantes != null)
            {
                sliderVidasRestantes.minValue = 0;
                sliderVidasRestantes.maxValue = personagem.getVidas();
            }

            if (sliderEnergiaRestate != null)
            {
                sliderEnergiaRestate.minValue = 0;
                sliderEnergiaRestate.maxValue = personagem.getEnergia();
            }
        }
    }

    void Update()
    {
        if (sliderVidasRestantes != null)
        {
            vidasRestantes = personagem.getVidas();
            sliderVidasRestantes.value = vidasRestantes;
        }

        if (sliderEnergiaRestate != null)
        {
            energiaRestate = personagem.getEnergia();
            sliderEnergiaRestate.value = energiaRestate;
        }
    }
}
