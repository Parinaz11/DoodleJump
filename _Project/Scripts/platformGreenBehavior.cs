using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGreenBehavior : MonoBehaviour
{

    public float jumpForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        Rigidbody2D rb =  collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null) {
            Vector2 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
