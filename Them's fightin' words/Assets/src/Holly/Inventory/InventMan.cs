/*
* Filename: InventMan.cs
* Developer: Holly Keir
* Purpose: This file is the invenotry manager
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* A class that use singleton to control the inventory 
*/
public class InventMan : MonoBehaviour 
{
    public List<GameObject> InventoryList;
    [SerializeField] public GameObject InventoryApple;
    [SerializeField] public GameObject InventoryHeart;
    [SerializeField] public GameObject InventorySnow;

    //constructor is declared private 
    private static InventMan instance;

    //Instance methods provides way to instantiate the class and return instance of it.
    public static InventMan Instance 
    {
        get {
            //checks if the instance is null, and then sets it to obj of InventMan
            if (instance == null) {
                instance = FindObjectOfType<InventMan>();
                if(instance == null) {
                    GameObject obj = new GameObject();
                    obj.name = typeof(InventMan).Name;
                    instance = obj.AddComponent<InventMan>();
                }
            }
            return instance;
        }
    }

    /*
    * Function when the script instance is being loaded.
    * Only called once during the lifetime for the script.
    */
    private void Awake() 
    {
        
        //Keep only one InventMan script
        if (instance == null) {
            instance = this as InventMan;
        }
        else {
            Destroy(gameObject);
        }
    }

    /* 
    * Function called on the frame when the script is enabled.
    * Used to create the list of game objects and call the refreshInventory function.
    */
    private void Start() 
    {
            InventoryList = new List<GameObject> {
            InventoryApple,
            InventoryHeart,
            InventorySnow
        };
        refreshInventory();

        // If we are to uncomment the command below, it will run the autoRefresh function in the background.
        // This would be used to test if the fucntion work
        //StartCoroutine(autoRefresh());
    }

    /*
    * A function that checks all the game object in the inventory list.
    * If the item is meant to be inventory then the item is set to be active
    */
    public void refreshInventory()
    {
        foreach (GameObject item in InventoryList) {
            if (item.GetComponent<ItemClass>().inInventory) {
                item.SetActive(true);
            }
            else {
                item.SetActive(false);
            }
        }
    }

    /*
    * A function that allows for the inventory methods to be checked.
    */
    public IEnumerator autoRefresh() 
    {
    //IEnumerator stops the process and then able to return to that point. 
    // For testing inventory methods
        while (true) {
            //Does the action every 3 seconds
            yield return new WaitForSeconds(3);
            //Test for removeItem function. But calling the function
            removeItem("itemSlotSnow");
            //Used to print out if an item is in the inventory.
            Debug.Log("Is itemSlotSnow in inventory: " + checkInventory("itemSlotSnow"));
            //Calls the refreshInventory function to do the update. 
            refreshInventory();
            // Debug.Log("Refreshing Inventory");
        }
    }

    /*
    * Function to check if item is in inventory
    *
    * Parameters:
    * ItemName -- the name of the item you want to check if it is in the inventory.
    * 
    * Returns:
    * bool -- True if item in inInventory, false otherwise.
    */
    public bool checkInventory(string ItemName)
    {
        foreach (GameObject item in InventoryList) {
            Debug.Log(item.gameObject.name);
            if (item.gameObject.name == ItemName) {
                if (item.GetComponent<ItemClass>().inInventory) {
                    return true;
                }
            }
        }
        return false;
    }

    /*
    * Fucntion to remove an item from the inventory
    *
    * Parameters:
    * ItemName -- the name of the item you want to remove
    */
    public void removeItem(string ItemName)
    {
        //runs through all the items in the current Inventory List
        foreach (GameObject item in InventoryList) {
            //If the item is equal to the parameter name then set inInventory to false.  
            if (item.gameObject.name == ItemName) {
                item.GetComponent<ItemClass>().inInventory = false;
            }
        }
    }

}


// Singleton pattern used in this code to ensure only one instance of the object "inventory menu" is instantiated.
