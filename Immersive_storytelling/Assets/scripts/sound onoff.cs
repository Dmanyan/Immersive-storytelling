using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundonoff : MonoBehaviour
{
    public GameObject soundon;
    public GameObject soundoff;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            soundon.SetActive(true);
            soundoff.SetActive(false);
        }
           
    }
}
