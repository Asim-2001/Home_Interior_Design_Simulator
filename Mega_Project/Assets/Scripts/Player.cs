using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator PlayerAnim;
    public Rigidbody RB;
    public float w_speed, wb_speed;
    public bool walking;
    public Transform playerTrans;

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            RB.velocity = transform.forward * w_speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            RB.velocity = -transform.forward * wb_speed * Time.deltaTime;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PlayerAnim.SetTrigger("walk_cycle");
            PlayerAnim.ResetTrigger("idle");  
          walking = true;
        }
     if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            PlayerAnim.ResetTrigger("walk_cycle");
            PlayerAnim.SetTrigger("idle");
           
            walking = false;
        }
    
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            playerTrans.Rotate(0,- w_speed * Time.deltaTime, 0);

        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            playerTrans.Rotate(0,w_speed * Time.deltaTime, 0);

        }

    
       
    }
}
