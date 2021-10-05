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
    public GameObject NPCUI;
    public GameObject PLAYUI;
    public Text NPCTEXT, PLAYTEXT;
    private PlayerDialog playerDialog;

    [Header("Vars")]
    public NPCDialog[] dialogs;
    public int angerLevel;
    private int dialogIndex = 0;

    InputAction op1, op2, op3;

    #endregion
    #region UNITY
    protected override void Start() {
        base.Start();
        //Set Control Sceme
        op1 = controls.Conversation.Op1;
        op2 = controls.Conversation.Op2;
        op3 = controls.Conversation.Op3;

        op1.performed += GetAngrier;
        op2.performed += GetAngrier;
        op3.performed += GetAngrier;
        dialogs = GameManager.dm.ReadFile("No Files");
    }
    protected override void OnTriggerExit2D(Collider2D collision) {
        //Left bounding box disable chat UI
        base.OnTriggerExit2D(collision);
        DisableUI();
    }
    #endregion
    #region METHODS
    //Player spoke to NPC Start conversation
    public override void Interacted(InputAction.CallbackContext obj) {
        base.Interacted(obj);
        if (!inRange) return;

        if (NPCUI.activeInHierarchy) {
            DisableUI();
        }
        else {
            EnableUI();
        }
    }
    private void EnableUI() {
        //Turn on NPC UI
        NPCUI.SetActive(true);

        //Set Text to start
        SetText(dialogIndex);

    }
    private void DisableUI() {
        //Turn off UI
        NPCUI.SetActive(false);
        PLAYUI.SetActive(false);

        //Turn off keys
        op1.Disable();
        op2.Disable();
        op3.Disable();
        interactAction.Disable();
    }

    //Load fight once NPC angry enough
    public void Fight() {
        DisableUI();
        SceneManager.LoadScene("fight");
    }
    //Make NPC angerLevel change called on every conversation press. Changes the text
    public void GetAngrier(InputAction.CallbackContext obj) {
        if (!inRange) return;
        //Get what key was pressed
        int key;
        switch (obj.action.name) {
            case "Op1":
                key = 0;
                break;
            case "Op2":
                key = 1;
                break;
            case "Op3":
                key = 2;
                break;
            default:
                key = 0;
                Debug.LogError("Invalid Conversation Key registered: " + obj.action.name);
                break;
        }
        //Grab jump
        dialogIndex += playerDialog.GetDelta(key);
        //Grab anger level
        //Set next Text
        SetText(dialogIndex);
    }
    //Set the dialog text the user sees. Give it the index of the dialog in the array
    public void SetText(int index) {
        //Set NPC text
        NPCTEXT.text = dialogs[index].GetText();
        //Grab player Dialog Save it
        playerDialog = dialogs[index].playerDialog;
        if(playerDialog != null) {
            //Enable PlayerUI
            PLAYUI.SetActive(true);
            //Enable Player Keys
            op1.Enable();
            op2.Enable();
            op3.Enable();
            //Set Text of player
            PLAYTEXT.text = playerDialog.GetText();
        }
        else {
            //Disable PlayerUI
            PLAYUI.SetActive(false);
            //Disable Player Keys
            op1.Disable();
            op2.Disable();
            op3.Disable();
        }

    }
    #endregion
}
