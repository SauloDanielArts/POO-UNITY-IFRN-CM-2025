using UnityEngine;

public class Player : Personagem
{
    private SpriteRenderer spriteRenderer;
    public Transform arma;
   void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
  void Update()
    {
        
        //direita
        if (arma.rotation.eulerAngles.z > -90 
            && arma.rotation.eulerAngles.z < 90)
        {
            spriteRenderer.flipX = false;
        }
        
        //esquerda
        if (arma.rotation.eulerAngles.z > 90 
            && arma.rotation.eulerAngles.z < 270)
        {
            spriteRenderer.flipX = true;
        }



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
