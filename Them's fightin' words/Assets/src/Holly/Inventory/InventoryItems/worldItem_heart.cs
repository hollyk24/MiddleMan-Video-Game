using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldItem_heart : worldItem {
    public override void collisionCode() {
            Debug.Log("I'm a heart");
    }
}