using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame(){
        SceneManager.LoadScene("Fase1");
    }

    public void Credits(){
        SceneManager.LoadScene("Creditos");
    }

    public void ReturnMainMenu(){
        SceneManager.LoadScene("MenuInicial");
    }

    public void QuitGame(){
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
