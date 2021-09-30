using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
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

    private Controls controls;
    private InputAction action;
    #endregion
    #region UNITY
    private void Start() {
        controls = new Controls();
        action = controls.Player.Interact;

        action.performed += Call;
        action.Disable();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        popUp.SetActive(true);
        action.Enable();
    }
    private void OnTriggerExit2D(Collider2D collision) {
        popUp.SetActive(false);
        action.Disable();
    }
    #endregion
    #region
    public void Call(InputAction.CallbackContext obj) {
        popUp.SetActive(false);
    }
    #endregion
}
