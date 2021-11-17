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
