using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * lily Mason
 * THIS CLASS IS A MONSTER ITS REALLLY LARGE AND DOES A LOT
 * HERE BE DRAGONS
 * This class is to be added to any NPC that one has a conversation with
 * 
 * Potential subclasses for more specfic conversation types? Shop keeper ect
 */
public class Conversation : Interactable {
    #region VARS
    [Header("References")]
    public TextAsset conversationJson;

    GameObject NPCUI;
    GameObject PLAYUI;
    Slider ANGER;
    Text NPCTEXT, PLAYTEXT;
    Image NPCPORT, PLAYPORT;
    PlayerDialog playerDialog;
    Portaits npcPortaits, playPortaits;

    [Header("Vars")]
    public NPCDialog[] dialogs;
    public int angerLevel;

    private int dialogIndex = 1;

    InputAction[] ops;

    #endregion
    #region UNITY
    protected override void Start() {
        base.Start();
        //Set Control Sceme
        ops = new InputAction[3] { controls.Conversation.Op1, controls.Conversation.Op2 , controls.Conversation.Op3 };

        //Set references
        NPCUI = GameManager.NPCUI;
        PLAYUI = GameManager.PLAYUI;
        ANGER = GameManager.AngerBar;
        NPCTEXT = NPCUI.transform.GetComponentInChildren<Text>();
        PLAYTEXT = PLAYUI.transform.GetComponentInChildren<Text>();
        playPortaits = GameManager.PLAYER.GetComponent<Portaits>();
        npcPortaits = GetComponent<Portaits>();
        NPCPORT = NPCUI.transform.GetChild(0).GetComponent<Image>();
        PLAYPORT = PLAYUI.transform.GetChild(0).GetComponent<Image>();
        //Load dialog
        dialogs = GameManager.FM.ReadFile(conversationJson);
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
        //if (!inRange) return;

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
        ANGER.gameObject.SetActive(true);
        //Set Text to start
        SetText(dialogIndex);
        ANGER.value = angerLevel;
        //Turn on keys
        foreach (InputAction op in ops) {
            op.performed += GetAngrier;
        }
    }
    private void DisableUI() {
        //Turn off UI
        NPCUI.SetActive(false);
        PLAYUI.SetActive(false);
        ANGER.gameObject.SetActive(false);
        //Turn off keys
        foreach (InputAction op in ops) {
            op.performed -= GetAngrier;
        }
    }
    //Load fight once NPC angry enough
    public void Fight(InputAction.CallbackContext obj) {
        DisableUI();
        OnTriggerExit2D(null);
        SceneManager.LoadScene("fight");
    }
    //Make NPC angerLevel change called on every conversation press. Changes the text
    public void GetAngrier(InputAction.CallbackContext obj) {
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
        dialogIndex += playerDialog.GetJumpDelta(key);
        //Grab anger level
        angerLevel += playerDialog.GetAngerDelta(key);
        angerLevel = angerLevel < 0 ? 0 : angerLevel;
        ANGER.value = angerLevel;
        if(angerLevel >= 10) {
            //fight
            SetText(0);
            foreach (InputAction op in ops) {
                op.performed -= GetAngrier;
                op.performed += Fight;
            }
        }
        else {
            //Set next Text
            SetText(dialogIndex);
        }
    }
    //Set the dialog text the user sees. Give it the index of the dialog in the array
    public void SetText(int index) {
        //Set NPC text
        NPCTEXT.text = dialogs[index].GetText();
        //Set NPC portrait
        NPCPORT.sprite = npcPortaits.portraits[dialogs[index].GetEmotion()];
        //Grab player Dialog Save it
        playerDialog = dialogs[index].playerDialog;
        if(playerDialog.GetText() != "String not set") {
            //Enable PlayerUI
            PLAYUI.SetActive(true);
            //Enable Player Keys
            foreach (InputAction op in ops) {
                op.Enable();
            }
            //Set Text of player
            PLAYTEXT.text = playerDialog.GetText();
            //Set Portrait of player
            PLAYPORT.sprite = playPortaits.portraits[playerDialog.GetEmotion()];
        }
        else {
            //Disable PlayerUI
            PLAYUI.SetActive(false);
            //Disable Player Keys
            foreach (InputAction op in ops) {
                op.Disable();
            }
        }
    }
    #endregion
}
