using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventMan : MonoBehaviour {
    [SerializeField] public GameObject InventoryApple;
    [SerializeField] public GameObject InventoryHeart;
    [SerializeField] public GameObject InventorySnow;
    public List<GameObject> InventoryList;

    private void Start() {
            InventoryList = new List<GameObject> {
            InventoryApple,
            InventoryHeart,
            InventorySnow
        };
        // StartCoroutine(autoRefresh());
    }

    public void refreshInventory() {
        foreach (GameObject item in InventoryList) {
            if (item.GetComponent<ItemClass>().inInventory) {
                item.SetActive(true);
            }
            else {
                item.SetActive(false);
            }
        }
    }

    public IEnumerator autoRefresh() {
        while (true) {
            yield return new WaitForSeconds(3);
            refreshInventory();
            // Debug.Log("Refreshing Inventory");
        }
    }
}
