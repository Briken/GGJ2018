using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    AudioSource[] ambientNoises;
    GameObject[] npcChars;
    public GameObject closestNpc;
    public Button buttonPrompt;
    float distance;
    bool deliveryActive;

    public GameObject m_videoPlayer;
    public GameObject m_gameScore;
    
    public float promptRadius;

    public int m_finalScore = 1;
    public float m_countdownTimer;

	// Use this for initialization
	void Start ()
    {
        m_countdownTimer = 600;
        GameObject.Find("Timer").GetComponent<Text>().text = m_countdownTimer.ToString();

        deliveryActive = false;
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
        /*
         END CONDITIONS IN PLACE
         */
        m_countdownTimer -= Time.deltaTime;
        GameObject.Find("Timer").GetComponent<Text>().text = m_countdownTimer.ToString();
        if (m_countdownTimer < 0.0f)
        {
            m_videoPlayer.SetActive(true);
            m_gameScore.SetActive(true);
        }

        if (m_finalScore == 30)
        {
            m_videoPlayer.SetActive(true);
            m_gameScore.SetActive(true);
        }


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

        if (distance <= promptRadius && buttonPrompt.enabled == false)
        {
            buttonPrompt.enabled = true;
        }
        if (distance > promptRadius && buttonPrompt.enabled == true)
        {
            buttonPrompt.enabled = false;
        }

        if (buttonPrompt.enabled == true && Input.GetButtonDown("Fire1"))
        {
            deliveryActive = true;
            closestNpc.GetComponent<NPCScript>().speakToPat();
            GetComponentInChildren<Animator>().SetBool("deliveringLetter", deliveryActive);
            deliveryActive = false;
            GetComponentInChildren<Animator>().SetBool("deliveringLetter", deliveryActive);
        }
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
