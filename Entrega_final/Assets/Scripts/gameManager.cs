using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public int moedasNaFase;
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

    public void ReiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}