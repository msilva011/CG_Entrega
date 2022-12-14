using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public int moedasNaFase;
    public int vidas;
    public AudioSource somDaMoeda;
    public string nomeDaProximaFase;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DescontarMoedas()
    {
        moedasNaFase -= 1;
        somDaMoeda.Play();

        if (moedasNaFase <= 0)
        {
            SceneManager.LoadScene(nomeDaProximaFase);
        }
    }

    public void DescontarVidas()
    {
        vidas--;

        if(vidas < 1)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("GameOver");

        }
        else
        {
            ReiniciarPartida();

        }
    }

    public void ReiniciarPartida()
    {
            Debug.Log("Ainda tem vida");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
    }
}
