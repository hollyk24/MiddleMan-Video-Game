using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTile
{
    public bool hasCollision;
    public int tileLayer;
    //tileSprite
}
public class ObstTile : MapTile
{
    new public bool hasCollision = true;
    new public int tileLayer = 1;
}

public class InteractTile: ObstTile
{
    public bool interactable = true;
    public string interactionText;
}