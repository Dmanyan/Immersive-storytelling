using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger1 : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;
    public GameObject talk;
    public GameObject actor;
    public GameObject shooter;

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            talk.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                StartDialogue();
                talk.SetActive(false);
      
                shooter.SetActive(true);
                actor.SetActive(false);

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        talk.SetActive(false);
    }
    public void StartDialogue()
    {
        FindAnyObjectByType<DialogM>().OpenDialogue(messages, actors);
    }
    private void Start()
    {
        talk.SetActive(false);
        shooter.SetActive(false);
 
    }



}
[System.Serializable]
public class messages{
    public int actorId;
    public string message;
}
[System.Serializable]
public class actor
{
    public string name;
    public Sprite sprite;
}