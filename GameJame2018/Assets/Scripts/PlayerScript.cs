using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    GameObject[] npcChars;
    GameObject closestNpc;
    public Image buttonPrompt;
    float distance;
    public float promptRadius;


	// Use this for initialization
	void Start ()
    {
        npcChars = GameObject.FindGameObjectsWithTag("NPC");
	}
	
	// Update is called once per frame
	void Update ()
    {
        foreach (GameObject n in npcChars)
        {
            if (Vector3.Distance(transform.localPosition, n.transform.position) < distance)
            {
                distance = Vector3.Distance(transform.localPosition, n.transform.position);
                closestNpc = n;
            }
        }

        if (distance <= promptRadius && buttonPrompt.enabled == false)
        {
            buttonPrompt.enabled = true;
        }
        if (distance > promptRadius && buttonPrompt.enabled == true)
        {
            buttonPrompt.enabled = false;
        }

        if (buttonPrompt.enabled == true && Input.GetButtonDown("Interact"))
        {
            closestNpc.GetComponent<NPCScript>().speakToPat();
        }
    }
}
