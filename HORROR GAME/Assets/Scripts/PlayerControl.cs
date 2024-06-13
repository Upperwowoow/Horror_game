using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //player speed 
    public float speed = 10.0f;
    //player turnspeed 
    public float turnSpeed;
    //this will allow turn left rigth by pressing A or D
    public float horizontalInput;
    //this will allow player to go forward and back by pressing W or S
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player turn
        horizontalInput = Input.GetAxis("Horizontal");
        //player forward and backward
        forwardInput = Input.GetAxis("Vertical");

        //Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Move side way
     

        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
