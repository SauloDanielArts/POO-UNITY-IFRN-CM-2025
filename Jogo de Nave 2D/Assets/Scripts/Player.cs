using UnityEngine;

public class Player : Personagem
{
    public Transform saidaDoTiro;
    public GameObject tiro;
    
    public int municao = 100;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        // movimento
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3( velocidade* Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3( velocidade* Time.deltaTime, 0, 0);
        }
        

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3( 0,  velocidade* Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3( 0,  velocidade* Time.deltaTime, 0);
        }

        // impede que saia da camera

        if (gameObject.transform.position.x < Camera.main.gameObject.transform.position.x - 9.4f )
        {
            gameObject.transform.position = new Vector3(Camera.main.gameObject.transform.position.x - 9.2f,
                transform.position.y, transform.position.z);
        }

        if (gameObject.transform.position.x > Camera.main.gameObject.transform.position.x + 9.4f )
        {
            gameObject.transform.position = new Vector3(Camera.main.gameObject.transform.position.x + 9.2f,
                transform.position.y, transform.position.z);
        }

        
        if (gameObject.transform.position.y < Camera.main.gameObject.transform.position.y - 4.2f )
        {
            gameObject.transform.position = new Vector3(transform.position.x,
                Camera.main.gameObject.transform.position.y - 4.2f,
                transform.position.z);
        }

        if (gameObject.transform.position.y > Camera.main.gameObject.transform.position.y + 4.2f )
        {
            gameObject.transform.position = new Vector3(transform.position.x,
                Camera.main.gameObject.transform.position.y + 4.2f,
                 transform.position.z);
        }
        
        
        

        // tiro
        if (Input.GetKeyDown(KeyCode.Space) && municao > 0)
        {
            GameObject obj = Instantiate(tiro, saidaDoTiro.position, Quaternion.identity) as GameObject;
            obj.transform.rotation = saidaDoTiro.rotation;
            
            municao--;
        }


    }
}
