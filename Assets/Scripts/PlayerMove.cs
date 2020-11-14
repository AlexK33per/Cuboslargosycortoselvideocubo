using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    bool canjump;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(h * 7, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        

        if (Input.GetKeyDown(KeyCode.Space) && canjump == true)
        {
            canjump = false;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "ground")
        {
            canjump = true;
        }
    }
}
