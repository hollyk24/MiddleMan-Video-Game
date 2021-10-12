using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class NameTransfer : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;
    public InputField example;
    public string textInInput = "usernameEx";
    

    public void StoreName(){
        theName = inputField.GetComponent<Text>().text;

        string ReceivedString = theName;
        //Debug.Log(ReceivedString);
        if(string.IsNullOrEmpty(theName)){
            Debug.Log("input is empty");
            theName = textInInput;
            Debug.Log(theName);
        }

        else if(ReceivedString.All(char.IsLetterOrDigit)){
           //if(string.IsNullOrEmpty(theName)){
            Debug.Log("allowed");
            textDisplay.GetComponent<Text>().text = "Welcome " + theName + " to the game";
        } else {
            Debug.Log("not allowed");
            textDisplay.GetComponent<Text>().text = theName + " is an invalid username";
           }   
        
    }    
/*
  //For testing
  public void autoName(){
      if(string.IsNullOrEmpty(theName)){
          example.text = textInInput;
          Debug.Log("Input is empty");    
      }
  }   
*/

}
