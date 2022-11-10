using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_controller : MonoBehaviour
{
    Vector2 movementInput;
    Rigidbody2D rb;
    Animator anim;
    
    public float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
              print("what");
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    private void FixedUpdate() {
        if(movementInput != Vector2.zero){
        rb.MovePosition(rb.position+movementInput*moveSpeed * Time.fixedDeltaTime);
        anim.SetBool("isidle", false);   //   print("not idle");
            if(movementInput.x >= 0){
                anim.SetBool("isright", true);  //    print("right");
                }
                else {anim.SetBool("isright", false);    //   print("left");
                }
            }
        else {
        anim.SetBool("isidle", true); 
         // print("idle");
        }
    }


    void OnMove(InputValue movementValue) {
            movementInput = movementValue.Get<Vector2>();
        
    }


}
