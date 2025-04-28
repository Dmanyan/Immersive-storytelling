using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playanime : MonoBehaviour
{
    [SerializeField] private Animator Myanime;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            Myanime.SetBool("playB",true);
    }
}
