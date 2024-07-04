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
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.Translate(0, 30, 0);
            StartCoroutine(Disableimg());
        }



    }

    IEnumerator Disableimg()
    {
        yield return new WaitForSeconds(1);
        transform.Translate(0, -30, 0);
    }
}
