using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontos = 0;
    public TMPro.TextMeshProUGUI textoPontos;
    
    public int municao = 0;
    public TMPro.TextMeshProUGUI textoMunicao;
   
    private GameObject player;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        municao = player.GetComponent<Player>().municao;
    }

    void Update()
    {
        municao = player.GetComponent<Player>().municao;
        
        textoPontos.text = pontos.ToString();
        textoMunicao.text = municao.ToString();
        
        if( player.GetComponent<Player>().vida <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
