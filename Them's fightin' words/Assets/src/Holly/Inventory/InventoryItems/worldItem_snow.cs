/*
* Filename: WorldItem_Apple.cs
* Developer: Holly Keir
* Purpose: Unique code for each item
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* A class for the heart in the world
*/
public class worldItem_snow : worldItem 
{
    /*
    * The function that overrides the code in the collision code function
    */
    public override void collisionCode() 
    {
        Debug.Log("I'm snow");
    }
}

