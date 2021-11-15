using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow_fruit : snake_fruit
{
    public override void fruitSetup()
    {
        points = 300;
        duration = 3;
    }
}
