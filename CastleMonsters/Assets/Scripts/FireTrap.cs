using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    public float offTime = 2f; // tempo apagado
    public float onTime = 2f;  // tempo aceso

    private Animator anim;
    private Collider2D fireCollider;

    private bool isOn = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
        fireCollider = GetComponent<Collider2D>();

        StartCoroutine(FireCycle());
    }

    private System.Collections.IEnumerator FireCycle()
    {
        while (true)
        {
            // 1. Liga o fogo
            isOn = true;
            anim.Play("On");        // Nome do estado da ANIMAÇÃO
            fireCollider.enabled = true;
            yield return new WaitForSeconds(onTime);

            // 2. Apaga o fogo
            isOn = false;
            anim.Play("Off");       // Nome do estado da ANIMAÇÃO
            fireCollider.enabled = false;
            yield return new WaitForSeconds(offTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (!isOn) return;

        if (trigger.CompareTag("Player"))
        {
            RigidBodyPlayerController player = trigger.GetComponent<RigidBodyPlayerController>();

            if (player != null)
            {
                // dano
                player.DiminuirVida(1);
            }
        }
    }
}