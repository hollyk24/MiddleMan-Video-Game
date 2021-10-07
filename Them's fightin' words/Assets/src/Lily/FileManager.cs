using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileManager : MonoBehaviour{
    #region METHODS
    /**
     * Conversations are stored in JSON files. This loads them and contains the wrapper class needed in order to do so.
     * 
     */
    [System.Serializable]
    public struct WrapperArray {
        public NPCDialog[] dialog;
    }
    public NPCDialog[] ReadFile(TextAsset filename) {
        WrapperArray wrap = JsonUtility.FromJson<WrapperArray>(filename.text);
        return wrap.dialog;
    }
    #endregion
}
