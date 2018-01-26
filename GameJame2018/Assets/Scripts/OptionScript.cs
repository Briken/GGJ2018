using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionScript : MonoBehaviour {

    public Slider volumeSlider;
    public GameObject gameData;
    public GameObject gDataPfab;
    public string language;

	// Use this for initialization
	void Start ()
    {

        gameData = GameObject.Find("PersistentGameData");
        if (gameData != null)
        {
            Debug.Log("gdata found");
            UpdateValues();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void UpdateValues()
    {
        volumeSlider.GetComponent<Slider>().value = gameData.GetComponent<GameDataScript>().volume;
    }
    public void SetVolume()
    {
        gameData.GetComponent<GameDataScript>().UpdateVolume(volumeSlider.GetComponent<Slider>().value);
    }
    public void SetLanguage(string lang)
    {
        gameData.GetComponent<GameDataScript>().SetLanguage(lang);
    }
}
