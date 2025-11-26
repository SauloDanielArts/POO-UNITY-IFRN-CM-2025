using UnityEngine;

public class CriadorDeInimigos : MonoBehaviour
{
    public GameObject[] inimigos;
    public Transform[] posicaoDosInimigos;

    public float tempoDoNovoInimigo = 10; //segundos
    
    private float conometroDoInimigo = 0;
    
    void Start()
    {
        
    }

 
    void Update()
    {
        conometroDoInimigo += Time.deltaTime;

        if (conometroDoInimigo >= tempoDoNovoInimigo)
        {
            Transform ponto = posicaoDosInimigos[Random.Range(0, posicaoDosInimigos.Length)];
            
            GameObject inimigo = Instantiate(inimigos[Random.Range(0, inimigos.Length)],
            new Vector3( ponto.position.x, ponto.position.y, ponto.position.z), 
            ponto.rotation) as GameObject;
            
            conometroDoInimigo = 0;
        }

    }
}
