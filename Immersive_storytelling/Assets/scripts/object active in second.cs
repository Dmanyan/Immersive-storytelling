using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activedelay : MonoBehaviour
{
    public GameObject active;
    public GameObject nonact;
    public int second;
    public bool conditions;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            StartCoroutine(Showcut());
            
        }
           
    }
    void OnEnable()
    {
        conditions = false;
    }

    IEnumerator Showcut()
    {

        yield return new WaitForSeconds(second);
        conditions = true;
    }


    void Update()
    {

        if (conditions == true)
        {
            active.SetActive(true);

        }

    }
}
