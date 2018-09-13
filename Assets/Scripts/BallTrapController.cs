using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrapController : MonoBehaviour {

    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player") as GameObject;
    }

    // Update is called once per frame
    void Update () {
            Vector3 position = Vector3.Lerp(this.transform.position, player.transform.position, Time.deltaTime);
            this.transform.position = position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            AudioSource som = GetComponent<AudioSource>();
            som.Play();
            Destroy(other.gameObject);
        }
    }
}
