using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogwTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;
    public GameObject talk;
    public GameObject actor;
    public GameObject shooter;
    public GameObject blackout;
    public GameObject sound;
    public GameObject breath;

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            talk.SetActive(true);
            shooter.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                blackout.SetActive(true);
                sound.SetActive(true);
                breath.SetActive(false);
                

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
public class Messages{
    public int actorId;
    public string message;
}
[System.Serializable]
public class Actors
{
    public string name;
    public Sprite sprite;
}