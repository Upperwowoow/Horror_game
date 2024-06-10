using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarmeraMovement : MonoBehaviour
{
    public Vector2 turn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxis("Mouse x");
        turn.y += Input.GetAxis("Mouse y");
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
