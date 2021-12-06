/*
* Filename: ItemClass.cs
* Developer: Holly Keir
* Purpose: Used for all items in the item class to check if in inventory
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* A class used to set a boolean for if an item in in the inventory
*/
public class invItem_snow : ItemClass
{
    public override void Start()
    {
        IT = GameObject.Find("SaveManager").GetComponent<InventoryTracker>();
        inInventory = IT.snow;
    }
}

