/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemInteract : Interactable
{

    


    public override void Interacted(InputAction.CallbackContext obj) {
        base.Interacted(obj);

        GameManager.inventory.AddItem(new Item { itemType = Item.ItemType.Heart, amount = 1 });
        GameManager.uiInventory.SetInventory(GameManager.inventory);
        GameManager.inventory.RemoveItem();
        this.gameObject.SetActive(false);

        
      


        


    }



}
*/
