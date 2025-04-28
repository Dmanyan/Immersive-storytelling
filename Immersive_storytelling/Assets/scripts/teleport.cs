using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform target;
    public Transform player;
    public GameObject video;
    public GameObject bgm;
    public GameObject shoot;
    public GameObject breath;
    public int sec = 44;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            player.position = target.position;
            video.SetActive(true);
            bgm.SetActive(false);
        }
    }

    public bool conditions = false;
    void OnEnable()
    {
        StartCoroutine(Showcut());
        conditions = false;
    }

    IEnumerator Showcut()
    {

        yield return new WaitForSeconds(sec);
        conditions = true;

    }


    void Update()
    {

        if (conditions == true)
        {
            video.SetActive(false);
            shoot.SetActive(true);
            breath.SetActive(true);
        }

    }
}
