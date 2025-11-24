using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strawberry : MonoBehaviour
{
    public GameObject som;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.CompareTag("Player")) {
            RigidBodyPlayerController_fase1 player = col.gameObject.GetComponent<RigidBodyPlayerController_fase1>();
            player.allowedDJ = true;
            Destroy(gameObject);

            Instantiate(som);

        }
    }
}
