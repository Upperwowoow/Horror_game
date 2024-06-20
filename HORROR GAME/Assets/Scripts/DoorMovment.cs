using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            transform.Translate(0, 0, 1);
        }

    }
}
