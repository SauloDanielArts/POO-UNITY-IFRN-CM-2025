using System;
using System.IO.Pipes;
using UnityEngine;

public class Inimigo : Persoangem
{
    [SerializeField] private int dano = 1;

    public float raioDeVisao = 1;
    public CircleCollider2D _visaoCollider2D;

    [SerializeField] private Transform posicaoPlayer;
   
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    
    public AudioSource audioSource;
    
    private bool andando = false;

    public void setDano(int dano)
    {
        this.dano = dano;
    }

    public int getDano()
    {
        return this.dano;
    }


    void Start()
    {
     spriteRenderer = GetComponent<SpriteRenderer>(); 
     animator = GetComponent<Animator>();

     if (posicaoPlayer == null)
     {
         posicaoPlayer = GameObject.FindGameObjectWithTag("Player").transform;
     }

      raioDeVisao = _visaoCollider2D.radius;
     
      audioSource = GetComponent<AudioSource>();
      
    }

 
    void Update()
    {
        andando = false;

        if (getVida() > 0)
        {
            if (posicaoPlayer.position.x - transform.position.x > 0)
            {
                spriteRenderer.flipX = false;
            }

            if (posicaoPlayer.position.x - transform.position.x < 0)
            {
                spriteRenderer.flipX = true;
            }

            if (posicaoPlayer != null &&
                Vector3.Distance(posicaoPlayer.position, transform.position) <= raioDeVisao)
            {
                Debug.Log("No raio de visão: "+ posicaoPlayer.position);
                
                transform.position = Vector3.MoveTowards(transform.position, 
                    posicaoPlayer.transform.position,
                    getVelocidade() * Time.deltaTime);
                
                andando = true;

            }
        }

        if (getVida() <= 0)
        {
            animator.SetTrigger("Morte");
        }
        
        animator.SetBool("Andando", andando);
    }

    public void desative()
    {
        Destroy(gameObject);
    }

    public void playAudio()
    {
        audioSource.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && getVida() > 0)
        {
            //causa dano no player
            int novaVida = collision.gameObject.GetComponent<Persoangem>().getVida() - getDano();
            collision.gameObject.GetComponent<Persoangem>().setVida(novaVida);

            // zera a vida do inimigo
            setVida(0);
        }
    }
}
