using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    AudioSource[] ambientNoises;
    GameObject[] npcChars;
    GameObject closestNpc;
    public Image buttonPrompt;
    float distance;
    
    public float promptRadius;


	// Use this for initialization
	void Start ()
    {
        npcChars = GameObject.FindGameObjectsWithTag("NPC");
        ambientNoises = new AudioSource[GameObject.FindGameObjectsWithTag("AmbientNoise").Length]; 
        for(int i = 0; i < ambientNoises.Length; i++)
        {
            ambientNoises[i] = GameObject.FindGameObjectsWithTag("AmbientNoise")[i].GetComponent<AudioSource>();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        SpriteFlip();

        foreach (GameObject n in npcChars)
        {
            if (Vector3.Distance(transform.localPosition, n.transform.position) < distance)
            {
                distance = Vector3.Distance(transform.localPosition, n.transform.position);
                closestNpc = n;
            }
        }

        //foreach (AudioSource n in ambientNoises)
        //{
        //    float dist = Vector3.Distance(this.transform.localPosition, n.gameObject.transform.position);
        //    n.volume = (1 / dist) * n.gameObject.GetComponent<AmbientNoiseScript>().maxDistance;
        //}

        //if (distance <= promptRadius && buttonPrompt.enabled == false)
        //{
        //    buttonPrompt.enabled = true;
        //}
        //if (distance > promptRadius && buttonPrompt.enabled == true)
        //{
        //    buttonPrompt.enabled = false;
        //}

        //if (buttonPrompt.enabled == true && Input.GetButtonDown("Interact"))
        //{
        //    closestNpc.GetComponent<NPCScript>().speakToPat();
        //}
    }



    void SpriteFlip()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }
    }
}
