using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Transform topPoint;     
    public Transform bottomPoint;  

    public float speed = 2f;

    private float topY, bottomY;
    private int direction = 1;

    void Start()
    {
        bottomY = bottomPoint.position.y;
        topY = topPoint.position.y;
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * direction * Time.deltaTime);

        if (transform.position.y >= topY)
        {
            transform.position = new Vector2(transform.position.x, topY);
            direction = -1;
        }

        if (transform.position.y <= bottomY)
        {
            transform.position = new Vector2(transform.position.x, bottomY);
            direction = 1;
        }
    }
}
