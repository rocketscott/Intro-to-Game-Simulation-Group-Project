using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectil : MonoBehaviour
{
   public float speed;
   Vector3 targPos;
   Collider2D coll2d;
    // Start is called before the first frame update
    
    
    private void Start()
    {
        coll2d = GetComponent<Collider2D>();
        targPos = FindObjectOfType<player_controller>().transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targPos, speed * Time.deltaTime);
    if (transform.position == targPos)
    {
        Destroy(gameObject);
 
    }
    }

    private void OnTriggerEnter2D(Collider2D other){
       
        if(other.tag == "Player"){
                
       player_controller pc = other.GetComponent<player_controller>();
       pc.damage();
        Destroy(gameObject);
    
        }
    }
}
