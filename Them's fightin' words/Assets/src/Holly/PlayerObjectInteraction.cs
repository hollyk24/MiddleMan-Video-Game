using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerObjectInteraction : MonoBehaviour
{

    private Inventory inventory;

    private void Start() {
        //GameManager.inventory.AddItem(null);

        Debug.Log(inventory == null);
        Debug.Log(GameManager.uiInventory == null);

        GameManager.uiInventory.SetInventory(inventory);
    }
}
