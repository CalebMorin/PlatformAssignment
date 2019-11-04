using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class BananaController : MonoBehaviour
{
    //Player controller for Banana Man
    public BananaManStates bananaManStates;
    public GameController gameController;
    [Header("Snappy Snappy")]
    public Animator BananaAnimator;
    public SpriteRenderer bananaSpriteRenderer;
    public Rigidbody2D rBody;
    [Header("Stuff")]
    public float force;
    public float forceButForJumping;
    public bool isGrounded;
    public Transform ground;
    public Transform checkpoint;
    void Start()
    {
        bananaManStates = BananaManStates.IDLE;
        isGrounded = false;
    }
    private void Update()
    {
        isGrounded = Physics2D.BoxCast
            (
                transform.position,
                new Vector2(2.0f, 1.0f),
                0.0f,
                Vector2.down,
                1.0f,
                1 << LayerMask.NameToLayer("Ground")
            );
        if(Input.GetAxis("Horizontal") > 0)
        {//To the right
            bananaSpriteRenderer.flipX = false;
            if (isGrounded)
            {
                bananaManStates = BananaManStates.WALK;
                BananaAnimator.SetInteger("AnimState", (int)BananaManStates.WALK);
                rBody.AddForce(Vector2.right * force);
            }
        }
        if(Input.GetAxis("Horizontal") < 0)
        {//To the left now
            bananaSpriteRenderer.flipX = true;
            if (isGrounded)
            {
                bananaManStates = BananaManStates.WALK;
                BananaAnimator.SetInteger("AnimState", (int)BananaManStates.WALK);
                rBody.AddForce(Vector2.left * force);
            }
        }
        if((Input.GetAxis("Jump") > 0) && (isGrounded))
        {//One hop this time
            bananaManStates = BananaManStates.JUMP;
            BananaAnimator.SetInteger("AnimState", (int)BananaManStates.JUMP);
            rBody.AddForce(Vector2.up * forceButForJumping);
            isGrounded = false;
        }
        if (Input.GetAxis("Horizontal") == 0)
        {//STOP
            bananaManStates = BananaManStates.IDLE;
            BananaAnimator.SetInteger("AnimState", (int)BananaManStates.IDLE);
        }//Everybody clap your hands!
    }
}
