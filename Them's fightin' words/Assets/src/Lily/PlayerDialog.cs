using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerDialog : Dialog {
    [SerializeField]
    protected int[] deltaJump;
    [SerializeField]
    protected int[] angerDelta;
    #region DeltaJump
    //Set jumps
    public void SetJumpDelta(int a, int b, int c) {
        deltaJump = new int[]{ a, b, c };
    }
    public void SetJumpDelta() {
        SetJumpDelta(1, 2, 3);
    }
    //Get jump for dialog choice
    public int GetJumpDelta(int choice) {
        return deltaJump[choice];
    }
    #endregion
    #region AngerDelta
    public void SetAngerDelta(int a, int b, int c) {
        angerDelta = new int[] { a, b, c };
    }
    public void SetAngerDelta() {
        SetAngerDelta(0, 0, 0);
    }
    public int GetAngerDelta(int choice) {
        return angerDelta[choice];
    }
    #endregion
}
