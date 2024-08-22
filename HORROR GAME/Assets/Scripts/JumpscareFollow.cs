using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareFollow : MonoBehaviour
{
    public GameObject JumpscareModel;
    public GameObject JumpscareBox;
    private AudioSource playerAudio;
    public AudioClip jumpScareFollow;

    // Start is called before the first frame update
    void Start()
    {
        JumpscareModel.SetActive(false);

        playerAudio = GetComponent<AudioSource>();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            JumpscareModel.SetActive(true);

            StartCoroutine(Disableimg());

            playerAudio.PlayOneShot(jumpScareFollow, 1.0f);

        }



    }

    IEnumerator Disableimg()
    {
        yield return new WaitForSeconds(5);
        JumpscareModel.SetActive(false);
        JumpscareBox.SetActive(false);
    }
}
