using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{

    [SerializeField] private GameObject InventoryDisplayUI;
    [SerializeField] private bool isPaused;


    private void Update() {

     

        if (Input.GetKeyDown(KeyCode.Space)) {
            isPaused = !isPaused;
        }

        if (isPaused) {
            ActivateMenu();
        }
        else {
            DeactivateMenu();
        }

    }

    /* private void Start() {
         script = mainMenu.GetComponent<MainMenu>();
         Debug.Log(script.gamerunning);
     }
 */
    public void ActivateMenu() {
        Time.timeScale = 0;
        InventoryDisplayUI.SetActive(true);
    }

    public void DeactivateMenu() {
        Time.timeScale = 1;
        InventoryDisplayUI.SetActive(false);
    }
}
