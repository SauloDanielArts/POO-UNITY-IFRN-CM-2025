using System;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public string tagDoObjeto;
    public int dano = 1;
    
    public void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == tagDoObjeto)
        {
          int vidas =  colisao.gameObject.GetComponent<Personagem>().getVidas();
          colisao.gameObject.GetComponent<Personagem>().setVidas(vidas-dano);
        }
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
