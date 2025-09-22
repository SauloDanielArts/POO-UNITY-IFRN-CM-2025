using UnityEngine;

public class Inimigo : Personagem
{
    void Start()
    {
        
    }
    void Update()
    {
        if (getVida() <= 0)
        {
            Destroy(gameObject);
        }
    }
}

