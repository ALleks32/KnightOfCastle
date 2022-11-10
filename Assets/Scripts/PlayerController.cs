using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float MovementSpeed;
    Animator AnimatorPlayer;
    SpriteRenderer SpritePlayer;
    AudioSource SwordSwing;
    bool Attack = false;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        AnimatorPlayer = gameObject.GetComponent<Animator>();
        SpritePlayer = gameObject.GetComponent<SpriteRenderer>();
        SwordSwing = gameObject.GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        MoveHorizontal();
        AttackAnim();
        CrouchWalkAnim();
    }

    void MoveHorizontal()
    {
        if (Input.GetAxis("Horizontal") != 0 && AnimatorPlayer.GetBool("Attack_0") == false && AnimatorPlayer.GetBool("Attack_1") == false && AnimatorPlayer.GetBool("Crouch") == false)
        {            
            AnimatorPlayer.SetBool("Horizontal", true);
            if (Input.GetAxis("Horizontal") > 0)
            {
                gameObject.transform.position = new Vector2(gameObject.transform.position.x + (MovementSpeed / 10), gameObject.transform.position.y);
                SpritePlayer.flipX = false;
            }
            else
            {
                gameObject.transform.position = new Vector2(gameObject.transform.position.x - (MovementSpeed / 10), gameObject.transform.position.y);
                SpritePlayer.flipX = true;
            }
        }
        else
        {
            AnimatorPlayer.SetBool("Horizontal", false);
        }
    }
    void AttackAnim()
    {
        if (!Input.GetKey(KeyCode.S)&& AnimatorPlayer.GetBool("Crouch") == false)
        {


            if (Input.GetKey(KeyCode.Y)) 
            
                {
                AnimatorPlayer.SetBool("Attack_0", true);
                SwordSwing.Play();

            }
            else
            {
               
                    AnimatorPlayer.SetBool("Attack_0", false);
                
                
            }
            if (Input.GetKey(KeyCode.U))
            {
                AnimatorPlayer.SetBool("Attack_1", true);
                SwordSwing.Play();
            }
            else
            {
                AnimatorPlayer.SetBool("Attack_1", false);
            }
            if (AnimatorPlayer.GetBool("Attack_0") == true && AnimatorPlayer.GetBool("Attack_1") == true)
            {
                AnimatorPlayer.SetBool("Attack_0", false);
                AnimatorPlayer.SetBool("Attack_1", false);
            }
            
        }
    }

    void CrouchWalkAnim()
    {
        if (AnimatorPlayer.GetBool("Attack_0") == false && AnimatorPlayer.GetBool("Attack_1") == false)
        {

            if (Input.GetKey(KeyCode.S))
            {
                AnimatorPlayer.SetBool("Crouch", true);
            }
            else
            {
                AnimatorPlayer.SetBool("Crouch", false);
            }
            if (Input.GetAxis("Horizontal") != 0 && AnimatorPlayer.GetBool("Attack_0") == false && AnimatorPlayer.GetBool("Attack_1") == false && AnimatorPlayer.GetBool("Crouch") == true)
            {
                AnimatorPlayer.SetBool("Crouch", true);
                if (Input.GetAxis("Horizontal") > 0)
                {
                    gameObject.transform.position = new Vector2(gameObject.transform.position.x + (MovementSpeed / 20), gameObject.transform.position.y);
                    SpritePlayer.flipX = false;
                }
                else
                {
                    gameObject.transform.position = new Vector2(gameObject.transform.position.x - (MovementSpeed / 20), gameObject.transform.position.y);
                    SpritePlayer.flipX = true;
                }
            }
            if (Input.GetAxis("Horizontal") == 0 && AnimatorPlayer.GetBool("Crouch") == true)
            {
                AnimatorPlayer.speed = 0;
            }
            else
            {
                AnimatorPlayer.speed = 1;
            }

        }
    }
}




