using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileManager : MonoBehaviour{
    #region METHODS
    //read file to create Dialog Tree
    //Current Implementation is just to test other classes. Once they work than this will build trees.
    [System.Serializable]
    public struct WrapperArray {
        public NPCDialog[] dialog;
    }
    public NPCDialog[] ReadFile(TextAsset filename) {
        WrapperArray wrap = JsonUtility.FromJson<WrapperArray>(filename.text);
        //NPCDialog[] logs = new NPCDialog[4];
        //var diag1 = new NPCDialog();
        //diag1.SetText("This is dialog 1");
        //var play1 = new PlayerDialog();
        //play1.SetText("[1]Option Text 1\n[2]Option Text 2\n[3]Option Text 3");
        //play1.SetJumpDelta();
        //diag1.playerDialog = play1;
        //play1.SetAngerDelta(1, 2, 3);
        //logs[0] = (diag1);

        //for (int i = 1; i < 4; i++) {
        //    var diag2 = new NPCDialog();
        //    diag2.SetText("This is the end of the conversation " + (i+1));
        //    logs[i] = (diag2);
        //}
        //var wrap = new WrapperArray() { dialog = logs };
        //string json = JsonUtility.ToJson(wrap);
        //Debug.Log(json);
        //json = JsonUtility.ToJson(diag1);
        //Debug.Log(json);
        //return logs;
        return wrap.dialog;
    }
    #endregion
}
