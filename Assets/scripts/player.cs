using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
    
{
    private Rigidbody2D rb;
    private float speed = 5.1f;
   
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") == 1)
        {
            Debug.Log(Input.GetAxis("Horizontal") == 1);
        }
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        if(Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
            Debug.Log("walj;ko");
        }
    }
}
