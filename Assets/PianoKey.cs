using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PianoKey: MonoBehaviour {
  public GameObject[] keys = new GameObject[7];
  public VirtualButtonBehaviour[] vb = new VirtualButtonBehaviour[7];
  public GameObject[] playWhite = new GameObject[7];

  void Start() {
    for (int i = 0; i < 7; i++) {
      vb[i].RegisterOnButtonPressed(OnButtonPressed);
      vb[i].RegisterOnButtonReleased(OnButtonReleased);
      keys[i].SetActive(false);
      playWhite[i].SetActive(true);
    }
  }

  public void OnButtonPressed(VirtualButtonBehaviour vb) {
    int buttonIndex = System.Array.IndexOf(this.vb, vb);
    Debug.Log("Virtual Button " + buttonIndex + " wurde gedrückt.");
    keys[buttonIndex].SetActive(true);
    playWhite[buttonIndex].SetActive(false);
  }

  public void OnButtonReleased(VirtualButtonBehaviour vb) {
    int buttonIndex = System.Array.IndexOf(this.vb, vb);
    keys[buttonIndex].SetActive(false);
    playWhite[buttonIndex].SetActive(true);
  }
}