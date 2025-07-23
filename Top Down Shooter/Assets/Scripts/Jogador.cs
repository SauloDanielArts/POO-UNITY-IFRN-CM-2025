using UnityEngine;

public class Jogador : Personagem
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //esquerda
        {
            gameObject.transform.position -= new Vector3(getVelocidade()*Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.D)) //direira
        {
            gameObject.transform.position += new Vector3(getVelocidade()*Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.W)) //cima
        {
            gameObject.transform.position += new Vector3(0, getVelocidade()*Time.deltaTime,  0);
        }
        
        if (Input.GetKey(KeyCode.S)) //baixo
        {
            
            gameObject.transform.position -= new Vector3(0, getVelocidade()*Time.deltaTime,  0);

        }


    }
}
