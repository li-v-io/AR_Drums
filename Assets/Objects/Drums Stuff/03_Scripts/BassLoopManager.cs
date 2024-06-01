using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BassLoopManager : MonoBehaviour
{
    public VirtualButtonBehaviour Vb1;
    public GameObject bassSound;
    private bool isPlaying = false;
    private Coroutine bassLoopCoroutine;

    void Start()
    {
        Vb1.RegisterOnButtonPressed(OnButtonPressed);
        bassSound.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour Vb1)
    {
        if (!isPlaying)
        {
            isPlaying = true;
            bassLoopCoroutine = StartCoroutine(BassLoop());
        }
        else
        {
            isPlaying = false;
            StopCoroutine(bassLoopCoroutine);
            bassSound.SetActive(false); // Make sure to turn off the sound
        }
    }

    private IEnumerator BassLoop()
    {
        while (isPlaying)
        {
            bassSound.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            bassSound.SetActive(false);
            yield return new WaitForSeconds(0.5f);
        }
    }
}