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
        

        Vector3 pos = transform.position;
        Vector3 targetPosition = GameObject.Find("FirstPersonCharacter").gameObject.transform.position;

        Vector3 finalDirection;
        finalDirection.x = (targetPosition.x - pos.x);
        finalDirection.y = 1.0f;
        finalDirection.z = (targetPosition.z - pos.z);


        transform.forward = finalDirection;

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
