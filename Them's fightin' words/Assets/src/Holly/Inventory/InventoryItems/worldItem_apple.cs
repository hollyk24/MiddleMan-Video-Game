/*
* Filename: WorldItem_Apple.cs
* Developer: Holly Keir
* Purpose: Unique code for each item
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* A class for the apple in the world
*/
public class worldItem_apple : WorldItem 
{
    int HealthIncrease = 2; // "Decorator" pare
    /*
    * The function that overrides the code in the collision code function
    */
    public override void collisionCode() 
    {
        Debug.Log("I'm an apple");
    }

}


/* These could become decorator patterns when it comes to additional funciton adding. 
* Say we wanted to add health to the player for each item, then we could create a health() fucntion.
* This health() function would then be fixed for each item as concrete components
*/