using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobby : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public float  movespeed;
    public float jumpheigh;
    public KeyCode Spacebar;
     public KeyCode L;
     public KeyCode R;

public Transform groundCheck;
public float GroundCheckraduis;
public LayerMask whatIsGround;
private bool grounded;




    // Update is called once per frame
    void Update() {
       if (Input.GetKeyDown(Spacebar)&& grounded)
        {
            jump();
        }
         


          if (Input.GetKey(L))
        {
         GetComponent<Rigidbody2D>().velocity= new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
         if (GetComponent<SpriteRenderer>()!=null)
         {
          GetComponent<SpriteRenderer>().flipX=true;
         }

        }

 if (Input.GetKey(R))
        
    
        {
    

         GetComponent<Rigidbody2D>().velocity= new Vector2( movespeed, GetComponent<Rigidbody2D>().velocity.y);


if (GetComponent<SpriteRenderer>()!=null)
{
    GetComponent<SpriteRenderer>().flipX=false;
        }

        }
        


void jump(){

 
     
         GetComponent<Rigidbody2D>().velocity= new Vector2( GetComponent<Rigidbody2D>().velocity.x, jumpheigh);

      


}

void FixedUpdate()
{
grounded = Physics2D.OverlapCircle(groundCheck.position, GroundCheckraduis, whatIsGround);
}
}
   
}