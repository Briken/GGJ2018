using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{

    public string m_name;

    public bool m_isInfected;

    public bool m_letterDelivered;

    public UnityEngine.UI.Image letterRecipientImage;

    public GameObject speechBubble;

    public AudioClip speakSound;
    AudioSource m_audio;

	// Use this for initialization
	void Start ()
    {
        m_audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            m_isInfected = true;
        }
    }

    public void speakToPat()
    {
        speechBubble.SetActive(true);
        m_audio.PlayOneShot(speakSound);
    }
}
