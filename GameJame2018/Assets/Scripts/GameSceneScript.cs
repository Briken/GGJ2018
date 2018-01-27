using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneScript : MonoBehaviour {

    public GameObject uiTimer;
    Text timerText;
    public float gameTimer;
    bool isEnding;

	// Use this for initialization
	void Start () {
        timerText = uiTimer.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        gameTimer -= Time.deltaTime;
        if (gameTimer <= 0 && isEnding == false)
        {
            isEnding = true;
            EndGame();
        }
        timerText.text = gameTimer.ToString();
	}

    void EndGame()
    {

    }
}
