using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    RigidBodyPlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<RigidBodyPlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.DiminuirVida(1);
            
        }
    }
}
