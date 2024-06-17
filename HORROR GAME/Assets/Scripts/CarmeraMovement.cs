using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarmeraMovement : MonoBehaviour
{
    //not my code i got it from Royal skies 
    public Vector2 turn;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        //this will lock the mouse in one spot so it nt go everywhere.
        //but the carmera movement still can be move. 
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //this is why you tell the code that you want a mouse to be the carmera movement
        //carmera movemnt 
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
