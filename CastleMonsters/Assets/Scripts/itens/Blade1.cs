using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            RigidBodyPlayerController_fase1 player = collision.gameObject.GetComponent<RigidBodyPlayerController_fase1>();

            if (player != null)
            {
                player.DiminuirVida(1);
            }
        }
    }
}

