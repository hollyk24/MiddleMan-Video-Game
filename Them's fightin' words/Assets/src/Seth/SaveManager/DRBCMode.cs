using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DRBCMode : MonoBehaviour
{
    public SaveManager SM;
    public Toggle DRBCToggle;
    public void Awake()
    {
        SM = GameObject.FindGameObjectWithTag("SM").GetComponent<SaveManager>();
        DRBCToggle = GetComponent<Toggle>();
        DRBCToggle.isOn = SM.DRBC;
    }
    public void toggleBCMode(){
        if(SM.DRBC){
            SM.DRBC = false;
        } else {
            SM.DRBC = true;
        }
        DRBCToggle.isOn = SM.DRBC;
    }
}
