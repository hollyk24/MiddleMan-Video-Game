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
    //public InputField Name;

    public void StoreName(){
        theName = inputField.GetComponent<Text>().text;

        string ReceivedString = theName;
        //Debug.Log(ReceivedString);
        if(ReceivedString.All(char.IsLetterOrDigit)){
            Debug.Log("allowed");
            textDisplay.GetComponent<Text>().text = "Welcome " + theName + " to the game";
        } else {
            Debug.Log("not allowed");
            textDisplay.GetComponent<Text>().text = theName + " is an invalid username";
        }   
    }


}
