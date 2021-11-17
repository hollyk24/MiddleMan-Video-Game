
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory2 inventory2;
    public GameObject itemButton;

    private void Start() {

        inventory2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory2>();
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Player")) {
            for (int i = 0; i < inventory2.slots.Length; i++) {

                if (inventory2.isFull[i] == false) {
                    //Item can be added to inventory
                    inventory2.isFull[i] = true;
                    Instantiate(itemButton, inventory2.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
        
    }
}
