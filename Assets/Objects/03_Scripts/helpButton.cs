using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class helpButton : MonoBehaviour
{
    public GameObject explainVideo;
    public GameObject buttonOff;

    private bool isActive = false;
    public VirtualButtonBehaviour Vb;

    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        explainVideo.SetActive(false);
        buttonOff.SetActive(true);
    }

    public void OnButtonPressed(VirtualButtonBehaviour Vb)
    {
        if (isActive == false)
        {
            explainVideo.SetActive(true);
            buttonOff.SetActive(false);
            isActive = true;
        }
        else if (isActive == true)
        {
            explainVideo.SetActive(false);
            buttonOff.SetActive(true);
            isActive = false;
        }
    }
}