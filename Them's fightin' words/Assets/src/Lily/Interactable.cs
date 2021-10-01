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
 */
[RequireComponent(typeof(Collider2D))]
public class Interactable : MonoBehaviour{
    #region VARS
    [Header("References")]
    [Tooltip("The popup when the player is in range in order to tell them what button they should press")]
    public GameObject popUp;

    [Tooltip("Link to the player controls through the GameManager")]
    protected Controls controls;
    protected InputAction interactAction;
    #endregion
    #region UNITY
    protected virtual void Start() {
        //There is some other way to do this And i dont know
        //My initial thought for the use that I need would be to have this created on the game manager and for Seth to not use the PlayerInput componet
        //and instead call the controls from the manager
        controls = new Controls();
        interactAction = controls.Player.Interact;
        interactAction.Disable();

        //In child Starts.
        //Call parent start
        //Bind interact key to function
    }

    /**
     * When in bounding box display Key to interact with
     * use base.OnTrigger.... to call parent function in the child ones.
     */
    protected virtual void OnTriggerEnter2D(Collider2D collision) {
        //Entered Show Hint and enable key
        popUp.SetActive(true);
        interactAction.Enable();
    }

    protected virtual void OnTriggerExit2D(Collider2D collision) {
        //Left remove hit and disable key
        popUp.SetActive(false);
        interactAction.Disable();
    }
    #endregion
}
