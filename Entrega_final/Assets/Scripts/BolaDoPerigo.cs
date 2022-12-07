using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaDoPerigo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<gameManager>().ReiniciarPartida();
        }
    }
}
