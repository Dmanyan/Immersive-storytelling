using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class timeline : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cutscene;
    public GameObject shot;
    public bool conditions = false;
    void OnEnable()
    {
        StartCoroutine(Showcut());
        conditions = false;
    }

    IEnumerator Showcut()
    {

        yield return new WaitForSeconds(10);
        conditions = true;
    }


    void Update()
    {
      
        if (conditions == true)
        {
            cutscene.SetActive(true);

        }

    }
}
