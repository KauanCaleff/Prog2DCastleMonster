using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame(){
        SceneManager.LoadScene("MovementTest");
    }

    public void Credits(){
        SceneManager.LoadScene("Credito");
    }

    public void ReturnMainMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame(){
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
