using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StickyTile : TileDecorator
{
    public override string GetSubQualities()
    {
        return "This tile is super sticky. Eww ";
    }
}
