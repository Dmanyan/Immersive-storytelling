using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonshowup : MonoBehaviour
{
    public int delay = 6;
    public GameObject choice;
    
    public bool condition = false;


    void Start()
    {
        choice.SetActive(false);
        //  button1.SetActive(false);
        StartCoroutine(HideAndShow());
        condition = false;
    }

    IEnumerator HideAndShow()
    {

        yield return new WaitForSeconds(delay);
        // button1.SetActive(true);
        condition = true;


    }

    void Update()
    {
        if (condition == true)
        {
            choice.SetActive(true);
          

        }

    }
}
