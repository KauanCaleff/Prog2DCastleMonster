using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public GameObject leftPositionObject, rightPositionObject;
    private float rightPosition, leftPosition;
    public float speed;
    // Start is called before the first frame update
    private void Start()
    {
        leftPosition = leftPositionObject.transform.position.x;
        rightPosition = rightPositionObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if(transform.position.x < leftPosition)
        {
            transform.position = new Vector2(leftPosition, transform.position.y);
            speed *= -1;
        }

        if(transform.position.x > rightPosition)
        {
            transform.position = new Vector2(rightPosition, transform.position.y);
            speed *= -1;
        }
    }
}
