using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialog : Dialog {
    protected int[] deltaJump;
    //Set jumps
    public void SetDelta(int a, int b, int c) {
        deltaJump = new int[]{ a, b, c };
    }
    public void SetDelta() {
        SetDelta(1, 2, 3);
    }
    //Get jump for dialog choice
    public int GetDelta(int choice) {
        return deltaJump[choice];
    }
}
