/*
* Filename: WorldItem.cs
* Developer: Holly Keir
* Purpose: Used to see if we collide with item
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* A class used to determine collision with possible pickup items
*/
public class WorldItem : MonoBehaviour
{
    [SerializeField] public InventMan IM;
    [SerializeField] public GameObject InventoryItem;

    /*
    * A function that is run when the collision occurs
    */
    public virtual void collisionCode() 
    {
        Debug.Log("Override me");
    }

    /*
    * Function to check if the player collides with the ite
    * 
    * Parameters: 
    * collision -- the game object that is colliding
    */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player") 
        {
            // Set on the items, and when the tagged object (player) is collided with
            //Set that inventory item to true throught the item class
            InventoryItem.GetComponent<ItemClass>().inInventory = true;
            // Delete object from scene by setting it inactive
            gameObject.SetActive(false);
            //call the refreshInventory function so the picture of the item is added to invent screen
            IM.refreshInventory();
            // Allows for specific code to be dynamically bound to the specific item found.
            collisionCode();
        }
    }

}


/* The superclass of WorldItem contains the fucntion collision code and the collider code
* It has the dynamic function collision with keyword virtual so it can bind dynamically.
* Has the static code of how it collides remains the same for all world items.
* The subclasses of heart, apple, and snow have the override keyword that are specific to that item.
* Override tells compiler to "check" that no new methods added that we think are overrides.
*
* The worldItem_apple, etc are good for dynamic binding as they would allow feautres specific to the items to be added.
* For example a certain sound bit when that item is picked up, or a trigger for something to happen or add health.
* Has a fucntion that behaves differently but also contains the same collision function for all items
*/