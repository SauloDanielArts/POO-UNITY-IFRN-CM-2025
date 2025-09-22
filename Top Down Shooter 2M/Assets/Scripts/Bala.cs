using System;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private int dano;
    [SerializeField] private float velocidade;

    public void setDano(int dano)
    {
        this.dano = dano;
    }

    public int getDano()
    {
        return this.dano;
    }

    public void setVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float getVelocidade()
    {
        return this.velocidade;
    }

    void Start()
    {
        
    }
    
    void Update()
    {
       // transform.Translate(Vector3.right * velocidade * Time.deltaTime);
       // transform.Translate( new Vector3(velocidade * Time.deltaTime,0,0));
        transform.position += new Vector3(velocidade * Time.deltaTime,0,0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            int novaVida = 
                other.gameObject.GetComponent<Personagem>().getVida() 
                - getDano();
            other.gameObject.GetComponent<Personagem>().setVida(novaVida);
        }

        //gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
