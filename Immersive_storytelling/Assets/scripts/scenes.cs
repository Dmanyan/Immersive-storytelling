using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
    public int delay = 3;
    public string sceneName;
    public bool condition = false;


    void OnEnable()
    {
       
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
            SceneManager.LoadScene(sceneName);

        }

    }

}
