using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject narrativa;
    public GameObject jogabilidade;

    void Start() {

    }

    
    public void PlayGame(){
        SceneManager.LoadScene("Fase1");
    }

    public void Jogabilidade(){
        jogabilidade.SetActive(true);
    }
    public void Narrativa(){
        narrativa.SetActive(true);
    }

    public void ReturnMainMenu(){
        SceneManager.LoadScene("MenuInicial");
    }




    public void QuitGame(){
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
