﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColdTile : TileDecorator
{
    public override string GetSubQualities()
    {
        return "This tile is very cold. ";
    }
}
