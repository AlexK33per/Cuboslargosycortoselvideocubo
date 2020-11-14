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
        if(Input.GetKey("d"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        
        if (Input.GetKey("a"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (Input.GetKeyDown("w") && canjump == true)
        {
            canjump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 100, 0));
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
