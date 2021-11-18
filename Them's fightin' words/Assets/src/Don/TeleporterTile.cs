using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterTile : SpecialTiles
{
    TeleporterTile()
    {
        tileQualities = "This tile is a teleporter. ";
    }
    [SerializeField] public Transform tTarget;
    public override void tileEffect(Collider2D coll)
    {
        coll.gameObject.transform.position = (tTarget.position + new Vector3(0f, 0.5f, 0f));
        Debug.Log(coll.gameObject.transform.position.ToString());
    }
}