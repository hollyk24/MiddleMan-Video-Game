using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WarmTile : TileDecorator
{
    public override string GetSubQualities()
    {
        return "This tile is kinda warm. ";
    }
}
