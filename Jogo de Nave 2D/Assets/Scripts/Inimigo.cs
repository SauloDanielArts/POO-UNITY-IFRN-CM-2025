using UnityEngine;

public class Inimigo : Personagem
{
    public Transform saidaDoTiro;
    public GameObject tiro;

    public float intervaloDeTiro = 1f;
    private float timer = 0;
    
    public float distanciaDeAtaque = 3f;
    
    private GameObject player;

    public int pontos = 1;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

  
    void Update()
    {
        if (player != null)
        {
            timer += Time.deltaTime;

            if (timer >= intervaloDeTiro && Mathf.Abs(player.transform.position.x - transform.position.x) < distanciaDeAtaque)
            {
                GameObject obj = Instantiate(tiro, saidaDoTiro.position, Quaternion.identity) as GameObject;
                obj.transform.rotation = saidaDoTiro.rotation;
                timer = 0;
            }
        }

        if (vida <= 0)
        {
            Destroy(this.gameObject);

            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().pontos += pontos;
        }

    }
}
