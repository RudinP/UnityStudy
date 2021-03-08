using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody playerRigidbody;
    public GameManager gameManager;
    void Start()
    {
  
        playerRigidbody = GetComponent<Rigidbody>();

    }

 
    void Update()
    {
        if (gameManager.isGameOver == true) return;

        float inputX, inputZ;
        float fallspeed = playerRigidbody.velocity.y;

        inputX=Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed;
        velocity.y = fallspeed;
        playerRigidbody.velocity = velocity;

       
    }
}
