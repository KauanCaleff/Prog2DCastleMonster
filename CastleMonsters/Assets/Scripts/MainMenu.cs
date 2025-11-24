using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSound;
    
    private IEnumerator ChangeScene(string sceneName)
    {
        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
            yield return new WaitForSeconds(1); 
        }

        SceneManager.LoadScene(sceneName);
    }

    public void PlayGame()
    {
        StartCoroutine(ChangeScene("Fase1"));
    }

    public void Jogabilidade()
    {
        StartCoroutine(ChangeScene("Jogabilidade"));
    }

    public void Narrativa()
    {
        StartCoroutine(ChangeScene("Narrativa")); 
    }

    public void ReturnMainMenu()
    {
        StartCoroutine(ChangeScene("MenuInicial"));
    }

    public void QuitGame(){
        PlayClickSound();
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    private void PlayClickSound()
    {
        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}
