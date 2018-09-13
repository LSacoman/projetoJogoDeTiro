using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPauseController : MonoBehaviour {


    public void reiniciar()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void menuInicial()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MenuInicial", LoadSceneMode.Single);
        
    }
}
