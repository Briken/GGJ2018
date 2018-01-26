using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataScript : MonoBehaviour {

    public float volume;
    public bool isFrench;
    public bool isEnglish;
    public bool isDutch;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateVolume(float vol)
    {
        volume = vol;
    }
    public void SetLanguage(string lang)
    {
        if (lang == "French") { isFrench = true;  isEnglish = false; isDutch = false; }
        if (lang == "English") { isFrench = false; isEnglish = true; isDutch = false; }
        if (lang == "Dutch") { isFrench = false; isEnglish = false; isDutch = true; }
    }
}
