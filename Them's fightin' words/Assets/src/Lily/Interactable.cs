using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
/*
 * 
 * This is what all interactable classes should stem from
 * Unify visual indications for all interactable objects
 * Object must have a child object that has a display of what key
 * 
 * 
 * 
 * In all overridedded functions call base.functionname(). You need to have this class's functionality even if you need more.
 * 
 */
[RequireComponent(typeof(Collider2D))]
public class Interactable : MonoBehaviour{
    #region VARS
    [Header("Interactable References")]
    [Tooltip("The popup when the player is in range in order to tell them what button they should press")]
    public GameObject popUp;

    [Tooltip("Link to the player controls through the GameManager")]
    protected Controls controls;
    protected InputAction interactAction;
    #endregion
    #region UNITY

    /**
     * Grab controls and setup what the Interact key does
     * 
     * 
     */
    protected virtual void Start() {
        //All controls grab from the GameManager!
        controls = GameManager.CONTROLS;
        //This key is specfically used for Interactables. This key does not need to be managed by any other class; even children
        interactAction = controls.Player.Interact;
        interactAction.Disable();
    }

    /**
     * When in bounding box display Key to interact with
     */
    protected virtual void OnTriggerEnter2D(Collider2D collision) {
        //Entered Show Hint and enable key
        interactAction.performed += Interacted;
        popUp.SetActive(true);
        interactAction.Enable();
    }
    /**
     * When leaving bounding box stop displaying Key to interact with
     */
    protected virtual void OnTriggerExit2D(Collider2D collision) {
        //Left remove hit and disable key
        interactAction.performed -= Interacted;
        popUp.SetActive(false);
        interactAction.Disable();
    }
    #endregion
    #region METHODS
    /**
     * This is the function that is called when the interact key is pressed.
     * Any child's functionality with interacting will start here
     * 
     * 
     * In ALL functions that are called by a keypress have an inRange check,
     * or errors WILL happen as it will call on multiple instances of this, instead of just this one
     */
    public virtual void Interacted(InputAction.CallbackContext obj) {
        popUp.SetActive(false);
    }
    #endregion
}
