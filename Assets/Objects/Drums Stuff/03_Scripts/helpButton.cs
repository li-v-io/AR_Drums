using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class helpButton : MonoBehaviour
{
    public GameObject explainVideo;

    private bool isActive = false;
    public VirtualButtonBehaviour Vb;

    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        explainVideo.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour Vb)
    {
        if (isActive == false)
        {
            explainVideo.SetActive(true);
            isActive = true;
        }
        else if (isActive == true)
        {
            explainVideo.SetActive(false);
            isActive = false;
        }
    }
}