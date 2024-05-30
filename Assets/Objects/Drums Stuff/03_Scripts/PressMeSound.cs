using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PressMeSound : MonoBehaviour
{
    public GameObject musicNotesAndSound;
    public GameObject explainOn;
    public GameObject explainOff;
    public VirtualButtonBehaviour Vb;

    private bool isActive = false;

    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        musicNotesAndSound.SetActive(false);
        explainOff.SetActive(false);
        explainOn.SetActive(true);
    }

    public void OnButtonPressed(VirtualButtonBehaviour Vb)
    {
        if (isActive == false)
        {
            musicNotesAndSound.SetActive(true);
            explainOff.SetActive(true);
            explainOn.SetActive(false);

            isActive = true;
        }
        else if (isActive == true)
        {
            musicNotesAndSound.SetActive(false);
            explainOff.SetActive(false);
            explainOn.SetActive(true);

            isActive = false;
        }
    }
}