using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColdTile : TileDecorator
{
    public override string getSubQualities()
    {
        return "This tile is very cold. ";
    }
}
