using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip jumpClip;


    public AudioClip damageClip;

    public AudioClip dashClip;

    public AudioClip coinClip;


    public void PlayJump()
    {
        if (jumpClip)
            audioSource.PlayOneShot(jumpClip);
    }

    public void PlayDamage()
    {
        if (damageClip)
            audioSource.PlayOneShot(damageClip);
    }

    public void PlayDash()
    {
        if (dashClip)
            audioSource.PlayOneShot(dashClip);
    }

    public void PlayCoin()
    {
        if (coinClip)
            audioSource.PlayOneShot(coinClip);
    }

}