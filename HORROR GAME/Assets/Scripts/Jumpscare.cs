using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject JumpscareModel;
    public GameObject JumpscareBox;

    private AudioSource playerAudio;
    public AudioClip jumpScare;

    // Start is called before the first frame update
    void Start()
    {
        JumpscareModel.SetActive(false);
        //Audio
        playerAudio = GetComponent<AudioSource>();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            JumpscareModel.SetActive(true);

            StartCoroutine(Disableimg());

            playerAudio.PlayOneShot(jumpScare, 1.0f);

        }
       
        

    }

    IEnumerator Disableimg()
    {
        yield return new WaitForSeconds(2);
        JumpscareModel.SetActive(false);
        JumpscareBox.SetActive(false);
    }
}
