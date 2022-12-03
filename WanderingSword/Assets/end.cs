using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    
     Collider2D coll2d;
    // Start is called before the first frame update
    void Start()
    {
             coll2d = GetComponent<Collider2D>();
    }

    // Update is called once per frame


         private void OnTriggerEnter2D(Collider2D other){
       
        if(other.tag == "Player"){
                
                 print("You won!");
        Destroy(gameObject);
    }
}}
