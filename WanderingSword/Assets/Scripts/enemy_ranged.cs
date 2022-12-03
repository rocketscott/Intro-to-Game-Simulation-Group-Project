using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_ranged : MonoBehaviour
{ 
    public Transform target;
    public float siteDistance;
    public float attackSpeed;
    public GameObject pro;
    bool inRange;
    public Vector3 throwPosOffset;
    private float nextTime;

    Animator anim;
    SpriteRenderer spriteR;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        spriteR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < siteDistance)
        {
            if (transform.position.x > target.position.x)
            {
                spriteR.flipX = false;
        
            } else { spriteR.flipX = true; }


            anim.SetBool("isIdle", false);
            inRange = true;
       
       
            


        }
        else
        {
           
            if (Vector2.Distance(transform.position, target.position) > siteDistance+ 2)
               { anim.SetBool("isIdle", true); 
                    inRange = false;
               
               }
        }
        if (inRange)
         {
            if (Time.time > nextTime)
           { Instantiate(pro,transform.position-throwPosOffset, Quaternion.identity);
            nextTime = Time.time + attackSpeed;
            }
         }

    }
    
}
