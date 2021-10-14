using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkableTile: MonoBehaviour
{
    public bool walkable = true;
    public void cloneThisObject()
    {
        Instantiate(this);
    }
    public void debugOut(string s)
    {
        Debug.Log(s);
    }
}
