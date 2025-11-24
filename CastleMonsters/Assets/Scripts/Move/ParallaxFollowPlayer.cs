using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxFollowPlayer : MonoBehaviour
{
    public Transform player;          
    private float lastPlayerX;        

    public Transform[] layers;         
    public float[] speeds;            

    private void Start()
    {
        lastPlayerX = player.position.x;
    }

    private void LateUpdate()
    {
        float deltaX = player.position.x - lastPlayerX;

        for (int i = 0; i < layers.Length; i++)
        {
            layers[i].position += new Vector3(deltaX * speeds[i], 0f, 0f);
        }

        lastPlayerX = player.position.x;
    }
}
