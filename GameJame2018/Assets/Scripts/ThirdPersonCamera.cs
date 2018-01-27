using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{

    private Transform m_follow;

    private Vector3 m_targetPosition;

    public float m_distanceAway;
    public float m_distanceUp;
    public float m_smooth;




	// Use this for initialization
	void Start ()
    {
        m_follow = GameObject.Find("FPSController").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void LateUpdate()
    {
        m_targetPosition = m_follow.position + m_follow.up * m_distanceUp - m_follow.forward * m_distanceAway;

        transform.position = Vector3.Lerp(transform.position, m_targetPosition, Time.deltaTime * m_smooth);

        transform.LookAt(m_follow);
    }

}
