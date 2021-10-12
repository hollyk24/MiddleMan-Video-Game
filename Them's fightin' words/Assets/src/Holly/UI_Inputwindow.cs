/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class UI_InputWindow : MonoBehaviour
{
    private TextMeshProUGUI titleText;
    private TMP_InputField inputField;

    private void Awake(){
        Hide();

        titleText = transform.Find("titleText").GetComponent<TextMeshProUGUI>();
        inputField = transform.Find("inputField").GetComponent<TMP_InputField>();
    }


    public void Show(string titleString, string inputString, string validCharacters){
        gameObject.SetActive(true);

        titleText.text = titleString;

        inputField.onValidateInput = (string text, int charIndex, char addedChar) => {
           return ValidateChar(validCharacters, addedChar);
        };
        inputField.text = inputString;
    
    }

    public void Hide(){
        gameObject.SetActive(false);
    }

    private char ValidatedChar(string validCharacters, char addedChar){
        if(validCharacters.IndexOf(addedChar) != -1){
            //Valid
            return addedChar;
        } else {
            //Invalid
            return '\0';
        }

    }
}
*/