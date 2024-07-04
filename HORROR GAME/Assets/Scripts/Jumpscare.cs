using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject Jumpscare9;
    public GameObject JumpscareBox;

    // Start is called before the first frame update
    void Start()
    {
        Jumpscare9.SetActive(false);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Jumpscare9.SetActive(true);

            StartCoroutine(Disableimg());

        }
       
        

    }

    IEnumerator Disableimg()
    {
        yield return new WaitForSeconds(2);
        Jumpscare9.SetActive(false);
        JumpscareBox.SetActive(false);
    }
}
