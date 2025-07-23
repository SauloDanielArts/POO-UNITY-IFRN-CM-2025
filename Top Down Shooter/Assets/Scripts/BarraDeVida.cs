using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Slider sliderVidasRestantes;
    public Slider sliderEnergiaRestate;
    
    public Jogador jogador;
    [SerializeField]
    private int vidasRestantes = 0;
    [SerializeField]
    private int energiaRestate = 0;
    
  
    void Start()
    {
        if (jogador == null)
        {
            //jogador = GameObject.Find("Jogador").GetComponent<Jogador>();
            jogador = GameObject.FindWithTag("Player").GetComponent<Jogador>();
        }

        if (jogador != null)
        {
            sliderVidasRestantes.minValue = 0;
            sliderVidasRestantes.maxValue = jogador.getVidas();

            sliderEnergiaRestate.minValue = 0;
            sliderEnergiaRestate.maxValue = jogador.getEnergia();
        }
    }

    void Update()
    {
        vidasRestantes = jogador.getVidas();
        sliderVidasRestantes.value = vidasRestantes; 
        
        energiaRestate = jogador.getEnergia();
        sliderEnergiaRestate.value = energiaRestate;
    }
}
