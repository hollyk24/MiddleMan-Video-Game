﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Dialog {
    #region VARS
    //The text string of a dialog option
    [SerializeField]
    protected string text = "String not set";
    #endregion
    #region METHODS
    //Make it very clear how to interact with text in order to protect it as it is super important
    public string GetText() {
        return text;
    }
    public void SetText(string s) {
        text = s;
    }
    #endregion
}
