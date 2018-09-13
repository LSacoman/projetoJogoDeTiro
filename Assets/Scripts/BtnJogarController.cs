using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnJogarController : MonoBehaviour {

    public void jogar()
    {
        SceneManager.LoadScene("Jogo", LoadSceneMode.Single);
    }

}
