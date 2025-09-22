using UnityEngine;

public class Player : Personagem
{
   void Start()
    {
        
    }
  void Update()
    {
        //movimento para a esquerda
        if (Input.GetKey(KeyCode.A))
        {
          transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);  
        }

        //movimento para a direita
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);  
        }
        
        //movimento para a Cima
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0);  
        }
        
        //movimento para a Cima
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, getVelocidade() * Time.deltaTime, 0);  
        }

    }
}
