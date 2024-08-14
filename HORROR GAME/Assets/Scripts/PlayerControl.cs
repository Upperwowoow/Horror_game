using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public bool jumpscared;
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
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("END"))
        {
            SceneManager.LoadScene("Level 2");
        }

        else if (other.gameObject.CompareTag("END2"))
        {
            SceneManager.LoadScene("Level 3");
        }


        else if (other.gameObject.CompareTag("END3"))
        {
            SceneManager.LoadScene("Win");

        }

        else if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("Dead");
            jumpscared = true;

        }
    }

    
}
