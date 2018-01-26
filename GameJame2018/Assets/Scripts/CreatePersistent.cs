using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePersistent : MonoBehaviour {

    public GameObject persistentObj;
	// Use this for initialization
	void Start () {
        if (GameObject.Find("PersistentGameData") == null)
        {
            Instantiate(persistentObj);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
