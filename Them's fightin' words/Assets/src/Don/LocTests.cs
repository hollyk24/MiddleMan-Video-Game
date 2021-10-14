using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocTests : MonoBehaviour
{
    public bool checkWalkable(Vector3 tilePos)
    {
        Collider[] colliders;
        colliders = Physics.OverlapSphere(tilePos, 0.1f, 8);
        if(colliders.Length > 0)
        {
            return true;
        }
        return false;
    }
}
