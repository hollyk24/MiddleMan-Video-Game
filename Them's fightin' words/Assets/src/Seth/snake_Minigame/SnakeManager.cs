using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class SnakeManager : MonoBehaviour
{
    public static SnakeManager SM;
    public static Controls CONTROLS;
    public static GameObject SNAKEHEAD;

    private void Awake() {
        if(SM != null) SM = this;
        else Destroy(this);

        CONTROLS = new Controls();
        SNAKEHEAD = FindObjectOfType<snakeHead>().gameObject;
    }
}
