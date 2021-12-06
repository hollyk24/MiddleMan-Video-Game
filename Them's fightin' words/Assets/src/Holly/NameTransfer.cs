/*
* Filename: NameTransfer.cs
* Developer: Holly Keir
* Purpose: This file controls the input field
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


/*
* A class used to take the inputted name to be used for the username of the player
*/
public class NameTransfer : MonoBehaviour
{
    public GameObject InputField;
    public GameObject TextDisplay;
    public InputField Example;
    public string TheName;
    public string TextInput = "usernameEx";

    /* 
    * Function that takes the value inputed from the text field on the settings menu
    * Checks the length and if the inputed value is allowed.
    */
    public void StoreName() 
    {
        TheName = InputField.GetComponent<Text>().text;
        string ReceivedString = TheName;

        // If the input field is empty, it adds the usernameEx string
        // Sets TheName to the TextInput before setting textDisplay to TheName
        if (string.IsNullOrEmpty(TheName)) 
        {
            Debug.Log("input is Empty");
            TheName = TextInput;
            Debug.Log(TheName);
            TextDisplay.GetComponent<Text>().text = TheName;
        }

        // Takes the received string and checks that all digits are letters or numbers.
        // Allows for the TextDisplay to be used. Welcomes the player
        else if (ReceivedString.All(char.IsLetterOrDigit)) 
        {
            Debug.Log("allowed");
            TextDisplay.GetComponent<Text>().text = "Welcome " + TheName + ", to the game";
        }
        
        // If the field contains more than digits or letters, then the display says not a valid username.
        else 
        {
            Debug.Log("not allowed");
            TextDisplay.GetComponent<Text>().text = TheName + " is an invalid username";
        }

    }

}

