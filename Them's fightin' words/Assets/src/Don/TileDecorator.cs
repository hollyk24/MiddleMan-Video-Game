using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDecorator : SpecialTiles
{
    public override string getQualities()
    {
        return tileQualities + getSubQualities();
    }
    public virtual string getSubQualities()
    {
        return "";
    }
}
