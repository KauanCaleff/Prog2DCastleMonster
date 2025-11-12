using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RigidBodyPlayerController : MonoBehaviour
{
    // Componentes
    private Animator playeranim;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidBody;

    private float horizontalInput;
    private bool jump;
    public float speed;
    public int vida = 3;
    public int coin;
    public float jumpForce;
    private bool isGrounded = false;

    // Double Jump
    private bool canDoubleJump = false;

    // Dash
    public float dashForce = 15f;
    public float dashDuration = 0.2f;
    public float dashCooldown = 1f;
    private bool isDashing = false;
    private bool canDash = true;

    public Text cointxt;
    public Text startxt;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playeranim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isDashing) return;

        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                jump = true;
                canDoubleJump = true; 
            }
            else if (canDoubleJump)
            {
                jump = true;
                canDoubleJump = false;
            }
        }

        // Dash (Shift esquerdo)
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }

        Death();
    }

    void FixedUpdate()
    {
        if (isDashing) return; // não move horizontalmente durante o dash

        Move();

        if (jump)
        {
            Jump();
            jump = false;
        }

        Animations();
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
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0); // reseta velocidade vertical
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isGrounded = false;
    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;

        float originalGravity = rigidBody.gravityScale;
        rigidBody.gravityScale = 0; // remove a gravidade
        rigidBody.velocity = new Vector2((spriteRenderer.flipX ? -1 : 1) * dashForce, 0);

        yield return new WaitForSeconds(dashDuration);

        rigidBody.gravityScale = originalGravity;
        isDashing = false;

        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void Animations()
    {
        playeranim.SetFloat("speedx", Mathf.Abs(rigidBody.velocity.x));
        playeranim.SetFloat("speedy", rigidBody.velocity.y);
        playeranim.SetBool("onGround", isGrounded);
    }

    public void AumentarVida(int quantidade)
    {
        if (vida < 3 && vida > 0)
        {
            vida += quantidade;
            if (vida > 3) vida = 3;
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

    public void Death()
    {
        if (vida <= 0)
        {
            SceneManager.LoadScene("Dead Screen 1");
        }
    }
}