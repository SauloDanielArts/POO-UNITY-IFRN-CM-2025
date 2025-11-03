using UnityEngine;

public class Dano : MonoBehaviour
{
   [SerializeField] private int dano = 1;
    [SerializeField] private float velocidade = 1.5f;

    
     void Start()
    {
        
    }

    void Update()
    {
        
    }
    
     private void OnTriggerEnter2D(Collider2D colisao)
        {
            if (colisao.gameObject.CompareTag("Inimigo"))
            {
                //causa dano ao Inimigo
                int novaVida = colisao.gameObject.GetComponent<Personagem>().getVida() - dano;
                colisao.gameObject.GetComponent<Personagem>().setVida(novaVida);
            }
        }
        
     public void destroi()
     {
          Destroy(this.gameObject);
     }
}
