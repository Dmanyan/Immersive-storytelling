using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenesP : MonoBehaviour
{
    public int delay = 3;
    public string sceneName;
    public bool condition = false;


    void OnEnable()
    {
       
        //  button1.SetActive(false);
        
        condition = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            StartCoroutine(HideAndShow());
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
