using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   public Carro carro;

   private float contador;
   
    void Start()
    {
        contador = 0;
    }

   
    void Update()
    {
        if (contador > 10)
        {
            contador = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if ( carro.capotado == true)
        {
            contador += Time.deltaTime;
        }else
        {
            contador = 0;
        }

    }
}
