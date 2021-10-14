using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocTests : MonoBehaviour
{
    public bool checkWalkable(Vector2 tilePos)
    {
        Collider2D collider;
        collider = Physics2D.OverlapCircle(tilePos, 0.1f);
        //Debug.Log(collider);
        if(collider != null)
        {
            return true;
        }
        return false;
    }
}
