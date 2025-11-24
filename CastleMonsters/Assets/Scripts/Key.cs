using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            RigidBodyPlayerController player = collision.GetComponent<RigidBodyPlayerController>();

            if (player != null)
            {
                player.ColetarChave();
            }

            Destroy(gameObject); 
        }
    }
}