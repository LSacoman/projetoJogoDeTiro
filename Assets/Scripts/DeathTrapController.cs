using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrapController : MonoBehaviour {

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            AudioSource som = GetComponent<AudioSource>();
            //som.Play();
            Destroy(other.gameObject);
        }
    }
}
