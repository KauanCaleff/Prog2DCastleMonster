using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strawberry : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.CompareTag("Player")) {
            RigidBodyPlayerController_fase1 player = col.gameObject.GetComponent<RigidBodyPlayerController_fase1>();
            player.allowedDJ = true;
            Destroy(gameObject);
        }
    }
}
