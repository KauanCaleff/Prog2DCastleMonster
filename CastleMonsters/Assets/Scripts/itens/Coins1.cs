using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins1 : MonoBehaviour
{
    public AudioClip som;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            RigidBodyPlayerController_fase1 player = collision.gameObject.GetComponent<RigidBodyPlayerController_fase1>();
            player.Coin(1);
            Destroy(gameObject);

        }
    }
    

}
