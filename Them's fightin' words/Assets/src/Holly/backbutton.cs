/*
* Filename: BackButton.cs
* Developer: Holly Keir
* Purpose: Control for the back button
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*
* A class used for all back buttons
*/
public class backbutton : MonoBehaviour
{
    /*
    * Function that allows for the back button load the main menu scene.
    */
    public void UseBackButton() 
    {
        SceneManager.LoadScene("overWorld"); // I changed this so if you check the instructions during the game, it brings you back to the overworld -Seth
        Debug.Log("Back");
    }
}

