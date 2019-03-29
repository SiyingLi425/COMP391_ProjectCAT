using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // Public Variables
    public float speed = 10.0f;
    public float jumpHeight = 10.0f;
   
    //public Animator animator;

    // Private Variables
    private Rigidbody2D rBody;
    private bool jump = false;
 
     
    // Start is called before the first frame update
    // Use this for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

  
  
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = 0.00f;
        if(jump == true)
        {
            vert = Input.GetAxis("Jump");
        }



        // Debug.Log("H: " + horiz + " , V: " + vert);
        Vector2 newVelocity = new Vector2(horiz, vert);

        rBody.velocity = newVelocity * speed;

        //animator.SetFloat("direction x", newVelocity.x);
        //animator.SetFloat("direction y", newVelocity.y);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            Debug.Log("Reaction");
            jump = true;
        }
    }
}
