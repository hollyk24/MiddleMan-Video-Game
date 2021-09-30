using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
/*
 * lily Mason
 * This class is to be added to any NPC that one has a conversation with
 * 
 * Potential subclasses for more specfic conversation types? Shop keeper ect
 */
public class Conversation : MonoBehaviour {
    #region VARS
    [Header("References")]
    [Tooltip("The popup when the player is in range in order to tell them what button they should press")]
    public GameObject popUp;
    public GameObject chatUI;
    
    [Header("Temp Vars")]
    public string dialog;
    public Text text;

    private Controls controls;
    private InputAction action;
    #endregion
    #region UNITY
    private void Start() {
        //Temp need Gamemanager should be apart of main system
        controls = new Controls();
        action = controls.Player.Interact;

        action.performed += EnableUI;
        action.Disable();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        popUp.SetActive(true);
        action.Enable();
    }
    private void OnTriggerExit2D(Collider2D collision) {
        popUp.SetActive(false);
        action.Disable();
        chatUI.SetActive(false);
    }
    #endregion
    #region
    public void EnableUI(InputAction.CallbackContext obj) {
        if (chatUI.activeInHierarchy) {
            OnTriggerExit2D(null);
        }
        else {
            popUp.SetActive(false);
            text.text = dialog;
            chatUI.SetActive(true);
        }
    }
    #endregion
}
