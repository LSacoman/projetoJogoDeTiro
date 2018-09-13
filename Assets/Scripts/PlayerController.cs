using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;
    public GameObject menuPause;

	void Update () {
		var y = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		if (Input.GetKeyDown(KeyCode.Space)){
			Fire();
		}
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!menuPause.activeSelf)
            {
                menuPause.SetActive(true);
                Time.timeScale = 0.0f;
            }
            else
            {
                Time.timeScale = 1.0f;
                menuPause.SetActive(false);
            }
        }

		transform.Translate(0,0,z);
		transform.Rotate(0,y, 0);
	}

	void Fire() {
		var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		AudioSource som = GetComponent<AudioSource>();
		som.Play();
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6f;

		Destroy(bullet, 3.0f);
	}
}
