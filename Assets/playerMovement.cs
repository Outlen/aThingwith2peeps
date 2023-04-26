using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float MoveSpeed;
    private float playerX;
    private float playerY;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        playerRb.velocity = new Vector2(playerX, playerY);


        if (Input.GetKey(KeyCode.W))
        {
            playerY = MoveSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {  }
        else
        {
            playerY = 0f;
        }
                  
      
        if (Input.GetKey(KeyCode.S))
        {
            playerY = - MoveSpeed;
        }
        else if (Input.GetKey(KeyCode.W))
        { }
        else
        {
            playerY = 0f;
        }
       
        
        
        if (Input.GetKey(KeyCode.A))
        {
            playerX = - MoveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        { }
        else
        {
            playerX = 0f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerX = MoveSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        { }
        else
        {
            playerX = 0f;
        }
      }
}
