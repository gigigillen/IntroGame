using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystems;

public class PlayerController : MonoBehaviour
{


    public Vector2 moveValue; //public variable to store input movements
    public float speed; //public variable for speed

    void Start()
    {
        moveValue = new Vector2(0, 0); // Retrieve the input value as a Vector2 and assign it to moveValu

    }

    // called on a fixed time interval, used for physics calculations
    void FixedUpdate() {
       
        Vector3 movement = new Vector3(moveValue.x, 0.0f, moveValue.y); // Create a Vector3 for movement based on the input values

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.fixedDeltaTime); // Apply force to the Rigidbody to move the player
    }
}
