using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAnimator : MonoBehaviour {

    public Animation m_walkingAnimation;
    public Animation m_idleAnimation;
    public Animator controller;
    bool isWalking;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
<<<<<<< HEAD
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) && isWalking == false)
        {
            controller.SetBool("isWalking", true);
            isWalking = true;
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A))
        {
            controller.SetBool("isWalking", false);
            isWalking = false;
        }
=======
        
>>>>>>> origin/master


    }
}
