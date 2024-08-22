using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovment : MonoBehaviour
{



    //Audio
    private AudioSource playerAudio;
    public AudioClip DoorSound;
    // Start is called before the first frame update
    void Start()
    {
        //Audio
        playerAudio = GetComponent<AudioSource>();
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
            playerAudio.PlayOneShot(DoorSound, 1.0f);
        }



    }

    IEnumerator Disableimg()
    {
        yield return new WaitForSeconds(2);
        transform.Translate(0, -30, 0);
    }
}
