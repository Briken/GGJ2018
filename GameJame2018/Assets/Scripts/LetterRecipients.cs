using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterRecipients : MonoBehaviour {

    public GameObject[] letterRecipients;
    bool lettersActive;

    // Use this for initialization
    void Start()
    {   
        letterRecipients = GameObject.FindGameObjectsWithTag("VillagerImg");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {   
            FlipActiveLetters();   
        }
    }

    public void DeliverLetter()
    {
        for (int i = 0; i < letterRecipients.Length; i++)
        {
            foreach (GameObject m in GameObject.FindGameObjectsWithTag("NPC"))
            {
                if (letterRecipients[i] == m.GetComponent<NPCScript>().letterRecipientImage && m.GetComponent<NPCScript>().m_letterDelivered)
                {
                    letterRecipients[i].GetComponent<RecipientScript>().hasBeenInfected = true;
                }
            }
        }
    }

    public void FlipActiveLetters()
    {
        for (int i = 0; i < letterRecipients.Length; i++)
        {
            letterRecipients[i].GetComponent<RecipientScript>().GetActiveImage().enabled =! letterRecipients[i].GetComponent<RecipientScript>().GetActiveImage().enabled;
        }
    }
}
