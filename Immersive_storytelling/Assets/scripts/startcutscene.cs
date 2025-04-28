using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startcutscene : MonoBehaviour
{
    public int delay = 35;
    public GameObject cutScene;
    public GameObject sound;
    public bool condition = false;
    

    void Start()
    {
        sound.SetActive(false);
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
            cutScene.SetActive(false);
            sound.SetActive(true);

        }

    }
}
