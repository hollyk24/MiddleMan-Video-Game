using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * lily Mason
 * This class is to be added to any NPC that one has a conversation with
 * 
 * Potential subclasses for more specfic conversation types? Shop keeper ect
 */
public class Conversation : Interactable {
    #region VARS
    [Header("References")]
    public GameObject chatUI;
    
    [Header("Temp Vars")]
    public string dialog;
    public Text text;

    private InputAction yes;
    #endregion
    #region UNITY
    protected override void Start() {
        base.Start();
        interactAction.performed += EnableUI;


        //temp bind
        yes = controls.Conversation.Op1;
        yes.performed += Fight;
        yes.Disable();
    }
    protected override void OnTriggerExit2D(Collider2D collision) {
        //Left bounding box disable chat UI
        base.OnTriggerExit2D(collision);
        chatUI.SetActive(false);
        yes.Disable();
    }
    #endregion
    #region
    public void EnableUI(InputAction.CallbackContext obj) {
        //Interact key pressed
        //Disable UI since already open
        if (chatUI.activeInHierarchy) {
            OnTriggerExit2D(null);
        }
        //Enable UI since its not open
        else {
            popUp.SetActive(false);
            text.text = dialog;
            chatUI.SetActive(true);
            yes.Enable();
        }
    }
    public void Fight(InputAction.CallbackContext obj) {
        OnTriggerExit2D(null);
        SceneManager.LoadScene("fight");
    }
    #endregion
}
