/*
* Filename: SettingMenu.cs
* Developer: Holly Keir
* Purpose: This file is the Settings Menu Control
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


/*
* A class used to manipulate all buttons and features on the settings menu scene
*/
public class SettingMenu : MonoBehaviour
{
    //Used to take player input for their username
    public InputField MainInputField;
    public string PlayerName;

    /*
    * Function called on enable for input field manipulation
    */
    void Start()
    {
        //Changes the character limit in the main input field. The limit will be the length of the player name.
        MainInputField.characterLimit = PlayerName.Length;
    }

    /*
    * Function to set the volume from the sliding bar.
    *
    * Parameters: 
    * volume -- data type of not an interger (decimals) for the volume level
    */
    public void SetVolume (float volume)
    {
        //Only displays the volume value and does not actually change the volume. 
        //Further code would be required from sound managament.
        Debug.Log(volume);
    }
    
    /* 
    * Function for the back button on the menu.
    */
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Back");
    }

}

