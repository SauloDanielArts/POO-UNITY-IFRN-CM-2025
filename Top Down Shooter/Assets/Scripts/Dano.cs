using System;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public int dano = 1;
    public void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "Player")
        {
          int vidas =  colisao.gameObject.GetComponent<Jogador>().getVidas();
          colisao.gameObject.GetComponent<Jogador>().setVidas(vidas-dano);
        }
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
