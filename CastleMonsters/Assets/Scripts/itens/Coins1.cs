

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins1 : MonoBehaviour
{
    public AudioClip som;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            RigidBodyPlayerController_fase1 player = col.GetComponent<RigidBodyPlayerController_fase1>();

            if (player != null)
                player.Coin(1); 

            Destroy(gameObject); 
        }
    }
}
