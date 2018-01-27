using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientNoiseScript : MonoBehaviour {


    public float maxDistance;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(this.transform.localPosition, GameObject.FindGameObjectWithTag("Player").transform.localPosition);
        GetComponent<AudioSource>().volume = (1 / dist) * maxDistance;
        Debug.Log("Dist: " + dist.ToString() + " Vol: " + GetComponent<AudioSource>().volume.ToString());
    }
}
