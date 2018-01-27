using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public AudioClip clickPlay;
    public AudioClip optionsClick;
    public AudioClip exitClick;

    AudioSource m_audio;

	// Use this for initialization
	void Start ()
    {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void OnPlayGameClicked()
    {
        m_audio.PlayOneShot(clickPlay);
        PlayAndLoad(clickPlay.length, "GameScene");
    }

    public void OnOptionsClicked()
    {
        m_audio.PlayOneShot(optionsClick);
        PlayAndLoad(optionsClick.length, "OptionScene");
    }

    public void OnExitClicked()
    {
        m_audio.PlayOneShot(exitClick);
        PlayAndLoad(exitClick.length, "");
    }

    IEnumerator PlayAndLoad(float dur, string scene)
    {
        yield return new WaitForSeconds(dur);
        if (scene != "")
        {
            SceneManager.LoadScene(scene);
        }
        if (scene == "")
        {
            Application.Quit();
        }
    }
}
