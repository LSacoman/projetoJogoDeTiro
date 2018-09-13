using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletController : MonoBehaviour {

	void OnCollisionEnter(Collision other) {
		var hit = other.gameObject;
        if (hit.CompareTag("Enemy")) {
            Destroy(hit);
            Destroy(gameObject);

            float randomX = UnityEngine.Random.Range(-15, 15);
            float randomZ = UnityEngine.Random.Range(-15, 15);
            GameObject enemy = Instantiate(Resources.Load("Inimigo", typeof(GameObject))) as GameObject;
            enemy.transform.position = new Vector3(randomX, 1, randomZ);
            enemy.transform.rotation = Quaternion.Euler(0, UnityEngine.Random.Range(0, 360), 0);

            GameObject pontuacao = GameObject.Find("txtPontuacao");
            string txtpontuacao = pontuacao.GetComponent<Text>().text;
            string[] teste = txtpontuacao.Split(' ');
            int pontos = int.Parse(teste[1]);
            pontos++;
            pontuacao.GetComponent<Text>().text = "Pontos: " + pontos.ToString();

        }
	}
}
