using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TileDecorator : SpecialTiles
{
    public override string GetQualities()
    {
        return GetSubQualities();
    }
    public virtual string GetSubQualities()
    {
        return "";
    }
}
