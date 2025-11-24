using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Transform topPoint;     // ponto mais alto
    public Transform bottomPoint;  // ponto mais baixo

    public float speed = 2f;

    private float topY, bottomY;
    private int direction = 1; // 1 = sobe, -1 = desce

    void Start()
    {
        bottomY = bottomPoint.position.y;
        topY = topPoint.position.y;
    }

    void Update()
    {
        // move somente no eixo Y
        transform.Translate(Vector2.up * speed * direction * Time.deltaTime);

        // Se chegou no topo, desce
        if (transform.position.y >= topY)
        {
            transform.position = new Vector2(transform.position.x, topY);
            direction = -1;
        }

        // Se chegou no fundo, sobe
        if (transform.position.y <= bottomY)
        {
            transform.position = new Vector2(transform.position.x, bottomY);
            direction = 1;
        }
    }
}
