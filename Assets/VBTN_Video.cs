using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN_Video: MonoBehaviour {
    public GameObject FuerElise;
    public GameObject pro_Activ_Text;
    public GameObject Text_Learn;
    public GameObject Text_Pro;

    public bool isActive = false;
    public VirtualButtonBehaviour Vb;

    private learnScript learnScriptBool;

    void Start() {
        Vb.RegisterOnButtonPressed(OnButtonPressed);

        learnScriptBool = FindObjectOfType < learnScript > ();

        FuerElise.SetActive(false);
        pro_Activ_Text.SetActive(false);
        Text_Learn.SetActive(true);
        Text_Pro.SetActive(true);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        if (learnScriptBool.isActive) {
            Debug.Log("Sorry, we can't play that now because learnScript is already playing.");
        } else {
            if (isActive == false) {
                FuerElise.SetActive(true);
                pro_Activ_Text.SetActive(true);

                Text_Learn.SetActive(false);
                Text_Pro.SetActive(false);
                isActive = true;
            } else if (isActive == true) {

                FuerElise.SetActive(false);
                pro_Activ_Text.SetActive(false);

                Text_Learn.SetActive(true);
                Text_Pro.SetActive(true);
                isActive = false;
            }
        }
    }
}