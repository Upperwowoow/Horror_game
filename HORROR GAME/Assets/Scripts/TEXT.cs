using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEXT : MonoBehaviour
{
    public GameObject Text;
    

    // Start is called before the first frame update
    void Start()
    {
        Text.SetActive(false);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Text.SetActive(true);

            StartCoroutine(Disableimg());

        }



    }

    IEnumerator Disableimg()
    {
        yield return new WaitForSeconds(2);
        Text.SetActive(false);
        
    }
}
