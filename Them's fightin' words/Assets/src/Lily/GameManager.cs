using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * This stores references to all singleton classes in order to make them easier to accsess
 * Reduce the amount of finds
 * 
 */
public class GameManager : MonoBehaviour
{
    //Classes
    public static GameManager GM;
    public static Controls CONTROLS;
    public static FileManager FM;

    //Objects
    public static GameObject PLAYER;
    public static GameObject NPCUI;
    public static GameObject PLAYUI;
    public static Slider AngerBar;

    public static UI_Inventory uiInventory;
    public static Inventory inventory;
    private void Awake() {
        if (GM != null) GM = this;
        else Destroy(this);

        CONTROLS = new Controls();
        FM = FindObjectOfType<FileManager>();

        PLAYER = FindObjectOfType<playerMovement>().gameObject;
        NPCUI = FindObjectOfType<Canvas>().transform.Find("NPCChat").gameObject;
        PLAYUI = FindObjectOfType<Canvas>().transform.Find("PlayerChat").gameObject;
        AngerBar = FindObjectOfType<Canvas>().transform.Find("AngerMeter").GetComponent<Slider>();

        uiInventory = FindObjectOfType<UI_Inventory>();
        inventory = new Inventory();
    }


}
