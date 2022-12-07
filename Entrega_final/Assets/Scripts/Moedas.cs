using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<gameManager>().moedasNaFase += 1;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<gameManager>().DescontarMoedas();
            Destroy(this.gameObject);
        }
    }
}
