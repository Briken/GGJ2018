using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipientScript : MonoBehaviour {
    public bool hasBeenInfected;
    public Image undeliveredImage;
    public Image deliveredImage;

    // Use this for initialization
    void Start()
    {
        undeliveredImage.enabled = false;
        deliveredImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Image GetActiveImage()
    {
        if (hasBeenInfected)
        {
            return deliveredImage;
        }
        else
        {
            return undeliveredImage;
        }
    }
}
