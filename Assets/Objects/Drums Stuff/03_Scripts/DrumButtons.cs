using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DrumButtons : MonoBehaviour
{
    public GameObject[] drums = new GameObject[4];
    public VirtualButtonBehaviour[] vb = new VirtualButtonBehaviour[4];
    public GameObject[] playWhite = new GameObject[4];

    void Start()
    {
        for(int i = 0; i < 4; i++)
        {
            vb[i].RegisterOnButtonPressed(OnButtonPressed);
            vb[i].RegisterOnButtonReleased(OnButtonReleased);
            drums[i].SetActive(false);
            playWhite[i].SetActive(true);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        int buttonIndex = System.Array.IndexOf(this.vb, vb);
        Debug.Log("Virtual Button " + buttonIndex + " wurde gedrückt.");
        drums[buttonIndex].SetActive(true);
        playWhite[buttonIndex].SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        int buttonIndex = System.Array.IndexOf(this.vb, vb);
        drums[buttonIndex].SetActive(false);
        playWhite[buttonIndex].SetActive(true);
    }
}