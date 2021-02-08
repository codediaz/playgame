using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerJumpForce = 20f;
    public float playerSpeed = 5f;

    private Rigidbody2D myRigidbody2D; /*Interaction Components [Object]*/
    
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>(); /*Take a lot of Components for interaction*/
    }


    void Update() /*Update with one key, in this project with space*/
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, playerJumpForce);
        }
        myRigidbody2D.velocity = new Vector2(playerJumpForce, myRigidbody2D.velocity.y);
    }

    /*02/08/2021 Collision*/
    void OnTriggerEnter2D (Collider2D collision) 
    {
        if (collision.CompareTag("Item")) 
        {
            Debug.Log("Punto +1");
        }
        else if (collision.CompareTag("ItemBad")) 
        {
            Debug.Log("Muerte");
        }
    }
}
