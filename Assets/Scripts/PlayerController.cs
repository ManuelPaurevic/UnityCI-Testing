using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    // Start is called before the first frame update

    private float speed = 20.0f;        //Speed of the Player
    private float turnSpeed = 55.0f;    //Rotating Speed of the player

    private float horizontalInput;      //left/right player control
    private float forwardInput;         //foward/backwards player control
    
    void Start(){      
    }

    // Update is called once per frame
    void Update(){

        //Grabs Players Input 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves the vehicle foward or backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the vehicle left or right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
