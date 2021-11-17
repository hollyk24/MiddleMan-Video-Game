using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldItem : MonoBehaviour
{
    [SerializeField] public InventMan IM;
    [SerializeField] public GameObject InventoryItem;
    public virtual void collisionCode() {
        Debug.Log("Override me");
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player") {
            InventoryItem.GetComponent<ItemClass>().inInventory = true;
            gameObject.SetActive(false);
            IM.refreshInventory();
            collisionCode();
        }
    }
}
