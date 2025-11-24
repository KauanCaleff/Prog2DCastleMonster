using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hooftop : MonoBehaviour
{
    public float timeOnScreen = 4f; // tempo que a mensagem fica

    void Start()
    {
        gameObject.SetActive(true);
        Invoke("HideMessage", timeOnScreen);
    }

    void HideMessage()
    {
        gameObject.SetActive(false);
    }
}