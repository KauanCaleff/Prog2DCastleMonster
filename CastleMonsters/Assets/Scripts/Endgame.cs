using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            RigidBodyPlayerController player = collision.gameObject.GetComponent<RigidBodyPlayerController>();
            WinScreen();
        }
    }

    public void WinScreen(){
        SceneManager.LoadScene("Win Screen");
    }
}
