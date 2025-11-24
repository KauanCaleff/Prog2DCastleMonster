using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cage : MonoBehaviour
{
    public GameObject cat;  // arraste o gato aqui

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            RigidBodyPlayerController player = collision.collider.GetComponent<RigidBodyPlayerController>();

            if (player != null && player.hasKey)
            {

                if (cat != null)
                    cat.SetActive(true);  

                Destroy(gameObject);     
            }
        }
    }
}