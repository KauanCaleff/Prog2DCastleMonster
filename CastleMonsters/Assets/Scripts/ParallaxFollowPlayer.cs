using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxFollowPlayer : MonoBehaviour
{
    [Header("Player")]
    public Transform player;          // arraste o player aqui
    private float lastPlayerX;         // para detectar quanto o player se moveu

    [Header("Camadas do Parallax")]
    public Transform[] layers;         // camadas (do fundo para a frente)
    public float[] speeds;             // mesma quantidade que layers

    private void Start()
    {
        lastPlayerX = player.position.x;
    }

    private void LateUpdate()
    {
        float deltaX = player.position.x - lastPlayerX;

        // move cada camada proporcionalmente
        for (int i = 0; i < layers.Length; i++)
        {
            layers[i].position += new Vector3(deltaX * speeds[i], 0f, 0f);
        }

        lastPlayerX = player.position.x;
    }
}
