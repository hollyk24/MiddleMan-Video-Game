using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldItem_apple : worldItem {
    public override void collisionCode() {
        Debug.Log("I'm an apple");
    }
}