using UnityEngine;

public class PararCarro : MonoBehaviour
{
   public Carro carro;
  
    void Start()
    {
        
    }
  void Update()
    {
        
    }

  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("Chao"))
    {
      carro.capotado = true;
    }
  }
  
  void OnCollisionExit2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("Chao"))
    {
      carro.capotado = false;
    }
  }

}
