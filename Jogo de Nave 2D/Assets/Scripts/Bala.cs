using System;
using UnityEditor;
using UnityEngine;

public class Bala : MonoBehaviour
{
   public float velocidade = 5f;
   public int dano = 10;
    
   private Renderer rend;

   public enum TipoDeBala
   {
       player, imigo
   }

   public TipoDeBala tipoDeBala = TipoDeBala.player;
   
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);

        if (rend != null && !rend.isVisible)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.CompareTag("Player") && tipoDeBala == TipoDeBala.imigo)
        {
            other.GetComponent<Player>().vida -= dano;
            
            Destroy(gameObject);
        }
        
        if ( other.CompareTag("Inimigo") && tipoDeBala == TipoDeBala.player)
        {
            other.GetComponent<Inimigo>().vida -= dano;
            
            Destroy(gameObject);
        }
    }
}
