using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RigidBodyPlayerController : MonoBehaviour
{
    
    private Rigidbody2D rigidBody;
    private float horizontalInput;

    public float speed;
    private bool jump;
    public int vida = 3; 
    public int coin;

    public float jumpForce;
    private bool isGrounded;
    
    //private Animator playeranim;
    private SpriteRenderer spriteRenderer; 

    public Text cointxt;
    public Text startxt;

    // Start is called before the first frame update
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        // playeranim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump")){
            jump = true;
        }
        Death();
    }

    void FixedUpdate()
    {
        Move();
        if (isGrounded && jump)
        {
            Jump();
        }
        jump = false;
        //Animations();
    }

    void Move()
    {
        rigidBody.velocity = new Vector2(horizontalInput * speed, rigidBody.velocity.y);

     
        if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false; 
        }
        else if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        
    }

    void Jump()
    {
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    //private void Animations()
    //{
    //    playeranim.SetFloat("speedx", Mathf.Abs(rigidBody.velocity.x));
    //    playeranim.SetFloat("speedy", rigidBody.velocity.y);
    //    playeranim.SetBool("onGround", isGrounded );
    //}

    public void AumentarVida(int quantidade)
    {
        if (vida < 3 && vida > 0)
        {
            vida += quantidade;

            if (vida > 3)
                vida = 3;
        }
        startxt.text = vida.ToString();
    }
    public void DiminuirVida(int quantidade)
    {
        vida -= quantidade;
        startxt.text = vida.ToString();
    }

    public void Coin(int quantity)
    {
        coin += quantity;
        cointxt.text = coin.ToString();
    }

    public void Death(){
        if (vida <= 0){
            SceneManager.LoadScene("Dead Screen 1");
        }
        
    }
}