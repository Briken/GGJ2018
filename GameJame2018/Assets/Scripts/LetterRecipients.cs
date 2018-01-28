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
        lettersActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            lettersActive =! lettersActive;
            GetComponentInChildren<Animator>().SetBool("openingMenu",lettersActive);
            StartCoroutine(MenuWait(1.0f));
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
        Image tempImage;
        Debug.Log(letterRecipients[0].GetComponent<RecipientScript>().GetActiveImage().name);
        for (int i = 0; i < letterRecipients.Length; i++)
        {
            tempImage = letterRecipients[i].GetComponent<RecipientScript>().GetActiveImage();
            Debug.Log(tempImage.name);
            tempImage.enabled = !tempImage.enabled;
        }
    }
    public IEnumerator MenuWait( float dur)
    {
        yield return new WaitForSeconds(dur);
        FlipActiveLetters();
    }
}
