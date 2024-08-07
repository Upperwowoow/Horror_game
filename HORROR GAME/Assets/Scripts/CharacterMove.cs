using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float speed;

    private Rigidbody enemyRb;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();

        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Character Moveforward 
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

        StartCoroutine(Disableimg());
    }

    IEnumerator Disableimg()
    {
        yield return new WaitForSeconds(2);
        Jumpscare9.SetActive(false);
        JumpscareBox.SetActive(false);
    }
}
