using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LocTests : MonoBehaviour
{

    public bool checkWalkable(Vector2 tilePos)
    {
        Collider2D collider;
        int layerMask = 1 << 8;
        collider = Physics2D.OverlapCircle(tilePos, 0.1f, layerMask);
        //Debug.Log(collider);
        if(collider != null)
        {
            return false;
        }
        return true;
    }
}
