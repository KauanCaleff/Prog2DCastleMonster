using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsFase1 : MonoBehaviour
{
    public GameObject som;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            RigidBodyPlayerController_fase1 player = collision.gameObject.GetComponent<RigidBodyPlayerController_fase1>();
            player.Coin(1);
            Destroy(gameObject);
            Instantiate(som);

        }
    }
    

}
