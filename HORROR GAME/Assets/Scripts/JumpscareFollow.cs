using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareFollow : MonoBehaviour
{
    public GameObject JumpscareModel;
    public GameObject JumpscareBox;

    // Start is called before the first frame update
    void Start()
    {
        JumpscareModel.SetActive(false);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            JumpscareModel.SetActive(true);

            StartCoroutine(Disableimg());

        }



    }

    IEnumerator Disableimg()
    {
        yield return new WaitForSeconds(4);
        JumpscareModel.SetActive(false);
        JumpscareBox.SetActive(false);
    }
}
