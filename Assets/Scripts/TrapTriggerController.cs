using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTriggerController : MonoBehaviour {

	public GameObject cubeTrap;
    public GameObject ballTrap;
    public GameObject deathTrap;
    public string type;

	private float randomX, randomZ;

	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			AudioSource som = GetComponent<AudioSource>();
			som.Play();
            
            switch (type)
            {
                case "cube":
                    for (int i = 0; i < 7; i++)
                    {
                        randomX = UnityEngine.Random.Range(-15, 15);
                        randomZ = UnityEngine.Random.Range(-15, 15);
                        var cube = (GameObject)Instantiate(cubeTrap, new Vector3(
                            randomX, 15, randomZ), Quaternion.identity);
                        Destroy(cube, 5.0f);
                    }
                    break;
                case "ball":
                    randomX = UnityEngine.Random.Range(-15, 15);
                    randomZ = UnityEngine.Random.Range(-15, 15);
                    var ball = (GameObject)Instantiate(ballTrap, new Vector3(
                            randomX, 15, randomZ), Quaternion.identity);
                    Destroy(ball, 10.0f);
                    break;
                case "death":
                    StartCoroutine(spawn());
                    break;
            }
		}
	}

    IEnumerator spawn()
    {
        for (int i =0; i<= 100;i++){
            randomX = UnityEngine.Random.Range(-15, 15);
            randomZ = UnityEngine.Random.Range(-15, 15);
            yield return new WaitForSeconds(0.01f);
            var death = (GameObject)Instantiate(deathTrap, new Vector3(randomX, 10, randomZ), Quaternion.identity);
            Destroy(death, 10.0f);
        }
    }
}
