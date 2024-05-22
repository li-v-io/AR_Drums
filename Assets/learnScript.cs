using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class learnScript: MonoBehaviour {

  public GameObject[] tips = new GameObject[11];
  public GameObject Text_Learn;
  public GameObject Text_Pro;

  public bool isActive = false;
  public VirtualButtonBehaviour Vb;

  private VBTN_Video VideoScriptBool;

  void Start() {
    Vb.RegisterOnButtonPressed(OnButtonPressed);

    VideoScriptBool = FindObjectOfType<VBTN_Video>();

    for (int i = 0; i < 11; i++) {
      tips[i].SetActive(false);
    }

    Text_Learn.SetActive(true);
    Text_Pro.SetActive(true);
  }

  public void OnButtonPressed(VirtualButtonBehaviour vb) {
    if (VideoScriptBool.isActive){
            Debug.Log("Sorry, we can't play that now because VideoScript is already playing.");
        }
        else{
    if (isActive == false) {
      for (int i = 0; i < 11; i++) {
        tips[i].SetActive(true);
      }

      Text_Learn.SetActive(false);
      Text_Pro.SetActive(false);
      isActive = true;
    } else if (isActive == true) {
      for (int i = 0; i < 11; i++) {
        tips[i].SetActive(false);
      }

      Text_Learn.SetActive(true);
      Text_Pro.SetActive(true);
      isActive = false;
    }}
  }
}