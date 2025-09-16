using UnityEngine;

public class Inimigo : Personagem
{
    [SerializeField] private int dano = 1;

    public void setDano(int dano)
    {
        this.dano = dano;
    }
    public int getDano()
    {
        return this.dano;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (getVida() <= 0)
        {
            //desativa o objeto do Inimigo
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Causa dano ao Player
            int novaVida = collision.gameObject.GetComponent<Personagem>().getVida() - getDano();
            collision.gameObject.GetComponent<Personagem>().setVida(novaVida);

            //collision.gameObject.GetComponent<Personagem>().recebeDano(getDano());
            
            //desativa quando bate no player
            gameObject.SetActive(false);
        }
    }
}
