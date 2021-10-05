using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour{
    #region METHODS
    //read file to create Dialog Tree
    //Current Implementation is just to test other classes. Once they work than this will build trees.
    public NPCDialog[] ReadFile(string filename) {
        List<NPCDialog> logs = new List<NPCDialog>();
        var diag1 = new NPCDialog();
        diag1.SetText("This is dialog 1");
        var play1 = new PlayerDialog();
        play1.SetText("[1]Option Text 1\n[2]Option Text 2\n[3]Option Text 3");
        play1.SetDelta();
        diag1.playerDialog = play1;

        logs.Add(diag1);

        for (int i = 0; i < 3; i++) {
            var diag2 = new NPCDialog();
            diag2.SetText("This is the end of the conversation " + (i+1));
            logs.Add(diag2);
        }

        return logs.ToArray();
    }
    #endregion
}
