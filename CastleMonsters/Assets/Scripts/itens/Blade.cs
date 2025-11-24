using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            RigidBodyPlayerController player = collision.gameObject.GetComponent<RigidBodyPlayerController>();

            if (player != null)
            {
                player.DiminuirVida(1);
            }
        }
    }
}

