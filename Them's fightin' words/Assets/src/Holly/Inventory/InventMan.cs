using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventMan : MonoBehaviour {
    [SerializeField] public GameObject InventoryApple;
    [SerializeField] public GameObject InventoryHeart;
    [SerializeField] public GameObject InventorySnow;
    public List<GameObject> InventoryList;
    private static InventMan instance;

    public static InventMan Instance {
        get {
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

    private void Awake() {
        
        //Keep only one InventMan script
        if (instance == null) {
            instance = this as InventMan;
        }
        else {
            Destroy(gameObject);
        }
    }
    private void Start() {
            InventoryList = new List<GameObject> {
            InventoryApple,
            InventoryHeart,
            InventorySnow
        };
        refreshInventory();
        //StartCoroutine(autoRefresh());
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
    // For testing inventory methods
        while (true) {
            yield return new WaitForSeconds(3);
            // removeItem("itemSlotSnow");
            Debug.Log("Is itemSlotSnow in inventory: " + checkInventory("itemSlotSnow"));
            refreshInventory();
            // Debug.Log("Refreshing Inventory");
        }
    }

    

    public bool checkInventory(string ItemName) {
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

    public void removeItem(string ItemName) {
        foreach (GameObject item in InventoryList) {
            if (item.gameObject.name == ItemName) {
                item.GetComponent<ItemClass>().inInventory = false;
            }
        }
    }
}

