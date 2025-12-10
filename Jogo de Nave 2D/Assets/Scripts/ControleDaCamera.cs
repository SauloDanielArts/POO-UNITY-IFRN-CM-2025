using UnityEngine;

public class ControleDaCamera : MonoBehaviour
{
   public float velocidadeDeDeslocamento = 3f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Translate(Vector2.right * velocidadeDeDeslocamento * Time.deltaTime);
    }
}
