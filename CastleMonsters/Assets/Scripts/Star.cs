using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject som_estrela;
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
            RigidBodyPlayerController player = collision.gameObject.GetComponent<RigidBodyPlayerController>();
            player.AumentarVida(1);
            Destroy(gameObject);
            Instantiate(som_estrela, transform.position, Quaternion.identity);
        }
    }

}
