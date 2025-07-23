using UnityEngine;

public class Persoangem : MonoBehaviour
{
    [SerializeField]
    private int vidas;
    [SerializeField]
    private int energia;
    [SerializeField]
    private float velocidade;

    public int getVidas()
    {
        return this.vidas;
    }

    public void setVidas(int vidas)
    {
        this.vidas = vidas;
    }

    public int getEnergia()
    {
        return this.energia;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public float getVelocidade()
    {
        return this.velocidade;
    }

    public void setVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }
}
